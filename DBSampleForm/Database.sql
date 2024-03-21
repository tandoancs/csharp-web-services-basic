create database planning_nhom04
go
use planning_nhom04
go
SET DATEFORMAT DDMMYYYY	
create table users
(
	user_code char(5) primary key,
	full_name nvarchar(30),
	permission varchar(30),
	production_line varchar(30),
	updated_by varchar(30),
	updated_date datetime
)
create table master_process
(
	process_code varchar(10)primary key,
	process_name nvarchar(30),
	process_status bit,
)
create table master_data
(
	item char(10)primary key,
	machine char(30),
	process_code varchar(36),
	width int,
	height int,
	scrap int,
	updated_by varchar(30),
	updated_date datetime,
)
create table account
(
	username varchar(30)primary key,
	password varchar(36),
	user_code char(5),
	foreign key(user_code) references users(user_code)
) 

insert into users(user_code,full_name,permission,production_line,updated_by)values('ST007',N'Cao Đơn Dương','1','htl','an.tran')
insert into users(user_code,full_name,permission,production_line,updated_by)values('ST002',N'Lý Gia Bảo','1','htl','an.tran')
insert into users(user_code,full_name,permission,production_line,updated_by)values('ST004',N'Nguyễn Hữu Đại','1','thermal','an.vu')
insert into users(user_code,full_name,permission,production_line,updated_by)values('ST005',N'Nguyễn Trần Hoàng Công Danh','standard','thermal','an.vu')
insert into users(user_code,full_name,permission,production_line,updated_by)values('ST003',N'Trần Gia Bảo','standard','htl','an.tran')
insert into users(user_code,full_name,permission,production_line,updated_by)values('ST001',N'Võ Ngọc Dương','standard','thermal','an.vu')
insert into users(user_code,full_name,permission,production_line,updated_by)values('AD001',N'Trần Thuận An','admin','htl','tan.doan')
insert into users(user_code,full_name,permission,production_line,updated_by)values('SU001',N'Tân Đoàn','super','all','an.tran')
insert into users(user_code,full_name,permission,production_line,updated_by)values('AD002',N'Vũ Hồng Ân','admin','thermal','tan.doan')

insert into master_process(process_code,process_name,process_status) values('ADM',N'Keo ADM',1)
insert into master_process(process_code,process_name,process_status) values('AG',N'Lớp Lót AG',1)
insert into master_process(process_code,process_name,process_status) values('BACKER',N'Mực Sau Backer',1)
insert into master_process(process_code,process_name,process_status) values('CLEAR',N'Lớp Clear',1)
insert into master_process(process_code,process_name,process_status) values('INK',N'Mực trước',1)

insert into master_data(item,machine,process_code,width,height,scrap,updated_by,updated_date) values('AT106331','ATMA','INK-ADM-AG-BACKER',330,480,15,'tan.doan','2023/04/08 15:03:59')
insert into master_data(item,machine,process_code,width,height,scrap,updated_by,updated_date) values('AT108292','AWT','INK-ADM-AG',550,700,17,'tan.doan','2023/04/08 15:05:01')
insert into master_data(item,machine,process_code,width,height,scrap,updated_by,updated_date) values('AT108299','ATMA','INK-AG-BACKER',450,600,12,'tan.doan','2023/04/11 20:08:21')
insert into master_data(item,machine,process_code,width,height,scrap,updated_by,updated_date) values('AT488405','SAKURAI','INK-ADM-AG-BACKER',330,480,15,'tan.doan','2023/04/11 20:08:22')
insert into master_data(item,machine,process_code,width,height,scrap,updated_by,updated_date) values('AT488760','AWT','INK-CLEAR-BACKER-AG',550,700,17,'tan.doan','2023/04/08 20:08:22')

insert into account(username,password,user_code) values ('an.tran','123456','AD001')
insert into account(username,password,user_code) values ('truong.hoang','123456','AD002')
insert into account(username,password,user_code) values ('anh.vu','123456','ST001')
insert into account(username,password,user_code) values ('binh.nguyen','123456','ST002')
insert into account(username,password,user_code) values ('khanh.dang','123456','ST003')
insert into account(username,password,user_code) values ('tan.doan','123456','SU001')

select *
from account
select *
from master_data
select *
from master_process
select *
from users
