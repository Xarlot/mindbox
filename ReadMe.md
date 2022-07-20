Привет

Допущения в проекте
1. Минимальную видимость в классов в проекте делать не стал, перенес в интернал неймспейс. В настоящих библиотеках (например у нас в DevExpress) так часто делают
2. Вычисление площади фигуры без знания типа фигуры в compile-time - непонятно что тут имелось ввиду. Сделал стандартный DI
3. Апи регистрации делать не стал, используется стандартное из autofac
4. Проект написан для демонстрации SOLID и testability, в реальной либе так конечно не пишут )

Второе задание
В каком виде в базе есть продукты и категории неизвестно, предположим в таком (mssql у меня нет, ddl накидал для postgres)
create table if not exists products
(
    name varchar(100) not null,
    id   serial
        constraint products_pk
            primary key
);

alter table products
    owner to postgres;

create unique index if not exists products_id_uindex
    on products (id);

create table if not exists categories
(
    id   serial
        constraint id
            primary key,
    name varchar(100) not null
);

alter table categories
    owner to postgres;

create table if not exists relations
(
    id          serial
        constraint relations_pk
            primary key,
    product_id  integer not null
        constraint product_id
            references products,
    category_id integer
        constraint category_id
            references categories
);

alter table relations
    owner to postgres;

create unique index if not exists relations_id_uindex
    on relations (id);

Тогда запрос будет например такой

select distinct p.name product, c.name category from relations
    join products p on relations.product_id = p.id
    left join categories c on relations.category_id = c.id
order by product