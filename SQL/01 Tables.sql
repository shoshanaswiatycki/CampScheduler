drop table if exists Location 
create table Location(
    Id int identity primary key,
    Name varchar(50) not null,
    MaxBunkCount int not null,
    IsIndoor bit not null
)




