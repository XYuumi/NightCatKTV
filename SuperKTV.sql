use master
go
if exists(select * from sysdatabases where name='SuperKTV')
drop database SuperKTV
go
--创建数据库
create database SuperKTV
go
--进入数据库
use SuperKTV
go
--歌手类型表
create table SingerType
(
	SingerTypeID int  primary key identity(1001,1),
	SingerTypeName varchar(20) not null unique
)
go

--歌手表
create table Singer(
	SingerID int primary key identity(1,1),
	SingerName	varchar(50)	not null,
	SingerTypeID	int	not null references SingerType(SingerTypeID),
	Gender	varchar(4)	check(Gender in ('男','女','组合')),
	Photo	varchar(200)
)
go
--歌曲分类表
create table SongType(
	SongTypeID int primary key identity(2001,1),
	SongTypeName	varchar(50)	not null
)
go
--歌曲表
create table Song(
	SongID	int primary key identity(1,1),
	SongName	varchar(50)	not null,
	Songab	varchar(50)	not null,
	SongWordCount	int	not null,
	SongTypeID	int	references SongType(SongTypeID),
	SingerID	int	references Singer(SingerID),
	Url	varchar(200)	not null,
	ClientCount	int not null default(0)
)
go
--管理员表
create table AdminInfo(
	AID int primary key identity(1,1),
	AName	Varchar(50)	not null,
	APwd	varchar(50)	not null
)
go

--资源文件表
create table ResourceUrl(
	RID int primary key identity(1,1),
	RName varchar(50) not null unique,
	RPath text not null
)
go
/*添加歌手类型*/
insert into SingerType values('大陆')
insert into SingerType values('港台')
insert into SingerType values('欧美')
insert into SingerType values('日韩')

/*添加歌曲分类*/
insert into SongType values('热门流行')
insert into SongType values('经典老歌')
insert into SongType values('影视金曲')
insert into SongType values('游戏动漫')
insert into SongType values('京剧戏曲')
insert into SongType values('儿歌')

/*添加歌手*/
insert into Singer values( 'Michael Jackson',1003,'男','Michael Jackson.jpg')
insert into Singer values( '安室奈美惠',1004,'女','安室奈美惠.jpg')
insert into Singer values( 'super junior',1003,'组合','super junior.jpg')
insert into Singer values( '左振元',1002,'男','侧田.jpg')
insert into Singer values( '东方神起',1004,'男','东方神起.jpg')
insert into Singer values( '王善勤',1002,'男','方大同.jpg')
insert into Singer values( 'SHE',1002,'女','何韵诗.jpg')
insert into Singer values( '后街男孩',1003,'组合','后街男孩.jpg')
insert into Singer values( '后弦',1001,'男','后弦.jpg')
insert into Singer values( '李云松',1001,'男','李谷一.jpg')
insert into Singer values( '汪艺',1004,'女','李孝利.jpg')
insert into Singer values( '李宇春',1001,'女','李宇春.jpg')
insert into Singer values( '林肯公园',1003,'组合','林肯公园.jpg')
insert into Singer values( '李咏琪',1001,'女','那英.jpg')
insert into Singer values( '苏打绿',1002,'组合','苏打绿.jpg')
insert into Singer values( '饶志凌',1002,'女','王若琳.jpg')
insert into Singer values( '唐玉胜',1001,'男','薛之谦.jpg')
insert into Singer values( '张国荣',1002,'男','张国荣.jpg')
insert into Singer values( '刘东旭',1002,'男','张学友.jpg')
insert into Singer values( '赵卫东',1002,'男','暂无图片.jpg')
insert into Singer values( '许嵩',1001,'男','许嵩.jpg')
insert into Singer values( '米津玄师',1004,'男','米津玄师.jpg')
insert into Singer values( '周杰伦',1001,'男','周杰伦.jpg')
insert into Singer values( 'Lukas Graham',1003,'男','lukas.jpg')
insert into Singer values( '乐正绫',1001,'女','乐正绫.jpg')
insert into Singer values( '洛天依',1004,'女','洛天依.jpg')
insert into Singer values( '薛之谦',1002,'男','薛之谦.jpg')
insert into Singer values( '言和',1003,'女','言和.jpg')
insert into Singer values( '华语群星',1001,'男','default.jpg')
insert into Singer values( '双笙',1001,'女','双笙.jpg')
insert into Singer values( 'RIDWIMPS',1004,'男','RADWIMPS.jpg')
insert into Singer values( '洛天依',1001,'男','洛天依.jpg')
insert into Singer values( '张学友',1001,'男','暂无图片.jpg')
insert into Singer values( '周玥',1002,'男','暂无图片.jpg')
insert into Singer values( '莫文蔚',1002,'女','timg6OU13L29.jpg')
insert into Singer values( '英雄联盟',1003,'组合','fa941c0b43b1ece027e87f642e8dc4a067b6975b162ed-Upsjxa_fw658.jpg')
insert into Singer values( 'サカナクション',1004,'组合','thQL2ZPDU7.jpg')
insert into Singer values( '大主宰乐团',1001,'组合','timgEISEQIJ0.jpg')
insert into Singer values( '华晨宇',1001,'男','timg1.jpg')
insert into Singer values( '纯音乐',1001,'女','timgN9MS3300.jpg')
insert into Singer values( '音乐黑市',1001,'男','timgN9MS3300.jpg')
insert into Singer values( 'Goi7',1003,'男','timgB786XU8O.jpg')
insert into Singer values( 'The Verkkars',1003,'组合','timg.jpg')
insert into Singer values( '小沈阳',1001,'男','小沈阳.jpg')


/*歌曲*/
--歌名，拼音，字数，歌曲类型，歌手编号，文件名，点击率
insert into Song values ('7Years','7YEARS',6,2001,10,'7Years.mp4',0)
insert into Song values('EZ4ENCE','EZ4ENCE',7,2001,10,'EZ4ENCE.mp4',0)
insert into Song values('那是你离开了北京的生活','NSNLKLBJDSH',11,2001,17,'那是你离开了北京的生活.flv',0)
insert into Song values('LOSER','LOSER',5,2001,23,'LOSER.flv',0)
insert into Song values('小情歌','XQG',5,2001,15,'小情歌.flv',0)
insert into Song values('等你下课','DNXK',4,2001,20,'等你下课.flv',0)
insert into Song values('幻听','HT',2,2001,21,'幻听.flv',0)
insert into Song values ('轮盘','LP',2,2002,1,'轮盘.mp4',default)
insert into Song values('乌合之众','WHZZ',4,2001,2,'乌合之众.MP4',0)
insert into Song values('罂粟花冠','YSHG',4,2003,2,'罂粟花冠.mp4',0)
insert into Song values ('狐狸','HL',2,2004,3,'狐狸.mp4',0)
insert into Song values('人偶师·得意之作','ROSDYZZ',7,2006,4,'人偶师·得意之作.mp4',0)
insert into Song Values('说好不哭','SHBK',4,2001,21,'说好不哭.mp4',0)
insert into Song Values('华为美','HWM',3,2001,22,'华为美.avi',0)
insert into Song Values('马步谣','MBY',3,2001,23,'马步谣.mp4',0)
insert into Song Values('勾指起誓','GZQS',4,2001,25,'勾指起誓.avi',0)
insert into Song Values('你的名字','NDMZ',4,2001,24,'你的名字.mp3',0)
insert into Song Values('7Years','NDMZ',4,2001,24,'7Years.mp4',0)
insert into Song Values('猪猪侠','NDMZ',4,2001,24,'猪猪侠.mp4',0)
insert into Song values ('吻别','WB',2,2002,1,'wenbie.mp3',default)
insert into Song values('alarm','alarm',5,2001,2,'alarm.MP3',0)
insert into Song values('everybody','everybody',9,2001,8,'everybody.mp3',0)
insert into Song values ('中国话','ZGH',3,2001,7,'中国话.mp3',0)
insert into Song values('不要爱上她','BYAST',5,2002,16,'不要爱上她.wma',0)
insert into Song values('布拉格广场','BLGGC',5,2002,19,'布拉格广场.WMA',0)
insert into Song values ('传说','CS',2,2002,19,'传说.mp3',0)
insert into Song values('单车恋人','DCLR',4,2003,10,'单车恋人.mp3',0)
insert into Song values('黑白','HB',2,2004,17,'黑白.mp3',0)
insert into Song values('说好不哭','SHBK',5,2001,20,'说好不哭.mp4',0)
insert into Song values('马步谣','MBY',3,2001,20,'马步谣.avi',0)
insert into Song values('小情歌','XQG',3,2001,20,'周玥 - 小情歌.mp4',0)
insert into Song values('EZ4ENCE (kannatuslaulu)','EZ4ENCE',7,2001,9,'The Verkkars - EZ4ENCE (kannatuslaulu).mkv',default)
insert into Song values('新宝島','XBD',3,2001,3,'サカナクション - 新宝島.mkv',0)
insert into Song values('春节序曲','CJXQ',4,2001,6,'纯音乐 - 春节序曲.mp3',0)
insert into Song values('涅槃','NP',2,2001,2,'英雄联盟 - 涅槃 (Phoenix).mkv',0)
insert into Song values('Sunburst (亚索台词版)','SUNBURST',13,2001,8,'Goi7 - Sunburst (亚索台词版).mp3',0)
insert into Song values('大笑江湖','DXJH',4,2001,47,'小沈阳 - 大笑江湖.mkv',0)
insert into Song values('剪刀刺客','JDCK',4,2001,4,'大主宰乐团 - 剪刀刺客.mkv',0)
insert into Song values('我管你 (真我版)','WGN',3,2001,5,'华晨宇 - 我管你 (真我版).mkv',0)
insert into Song values('一生所爱','YSSA',4,2001,1,'卢冠廷、莫文蔚 - 一生所爱.mkv',0)
insert into Song values('POPSTARS','POPSTARS',8,2001,2,'英雄联盟 - POPSTARS.mkv',0)
insert into Song values('7 Years','7YEARS',6,2001,7,'音乐黑市 - 鸣人配上这首歌真是一脸泪，那一年我也才《7 Years》.mkv',0)


/*获取资源*/
insert into ResourceUrl values('SingerPic','D:\MyKTV\SingerPhoto')		--歌手图片地址
insert into ResourceUrl values('SongPic','D:\MyKTV\SongPic')			--歌曲图片地址
insert into ResourceUrl values('Song','D:\MyKTV\Song')					--歌曲文件地址

/*添加管理员*/
insert into AdminInfo values('XYumi','020221')
insert into AdminInfo values('admin','123')
insert into AdminInfo values('河马','666')
insert into AdminInfo values('凹凸曼','999')


--删除歌曲
delete from Song where SongID = 49

--删除歌手
delete from Singer where SingerID =50

--修改管理员信息
update AdminInfo set AName = '123', APwd = '321' where AID = 7
--显示歌曲信息
select SongID, SongName, Songab, SongWordCount, a.SongTypeID,b.SingerName, c.SongTypeName, Url, ClientCount from song a, Singer b,SongType c where a.SingerID = b.SingerID and a.SongTypeID = c.SongTypeID
--显示歌手信息
select SingerID,SingerName,SingerTypeName,Gender,Photo from Singer,SingerType