create tablespace tbsappjvmetro datafile 'C:\app\Erik\oradata\produ\dtfappjvmetro.dbf' size 1024m extent management local segment space management auto;

create user met01 identified by met01 default tablespace tbsappjvmetro temporary tablespace temp account unlock;

grant connect, resource to met01;
grant alter any index to met01;
grant alter any sequence to met01;
grant alter any table to met01;
grant alter any trigger to met01;
grant alter any procedure to met01;
grant create any index to met01;
grant create any sequence to met01;
grant create any synonym to met01;
grant create any table to met01;
grant create any trigger to met01;
grant create any view to met01;
grant create procedure to met01;
grant create public synonym to met01;
grant create trigger to met01;
grant create view to met01;
grant delete any table to met01;
grant drop any index to met01;
grant drop any sequence to met01;
grant drop any table to met01;
grant drop any trigger to met01;
grant drop any view to met01;
grant insert any table to met01;
grant query rewrite to met01;
grant select any table to met01;
grant unlimited tablespace to met01;

select * from dba_profiles where resource_name like 'PASSWORD_LIFE_TIME';

alter profile default limit password_life_time unlimited;