drop table if exists ScheduleConstant

drop table if exists LocationTimeUnavailability
drop table if exists Location 
create table dbo.Location(
    Id int not null identity primary key,
    Name varchar(50) not null,
    MaxBunkCount int not null,
    IsIndoor bit not null
)
create table dbo.LocationTimeUnavailability(
    Id int not null identity primary key,
    LocationId int not null,
    TimeFrom time not null,
    TimeUntil time not null
)
drop table if exists Bunk
drop table if exists AgeGroup
create table dbo.AgeGroup(
    Id int not null identity primary key,
    Name varchar(50) not null,
    Age int not null,
    NumberOfBunks int
)
create table dbo.Bunk(
    Id int not null identity primary key,
    Name varchar(50) not null,
    AgeGroupId int not null,
    HeadCount int null
)
create table dbo.ScheduleConstant(
    Id int not null identity primary key,
    Name varchar(50) not null,
    AgeGroupId int not null,
    StartTime time not null,
    EndTime time not null,
    MaxStartTime time not null,
    MinStartTime time not null,
    LocationId int null
)\
drop table if exists Group 
create table dbo.Group(
    Id int not null identity primary key,
    Name varchar(50) not null
)
