use master
go
if exists(select * from sysdatabases where name='SuperKTV')
drop database SuperKTV
go
--�������ݿ�
create database SuperKTV
go
--�������ݿ�
use SuperKTV
go
--�������ͱ�
create table SingerType
(
	SingerTypeID int  primary key identity(1001,1),
	SingerTypeName varchar(20) not null unique
)
go

--���ֱ�
create table Singer(
	SingerID int primary key identity(1,1),
	SingerName	varchar(50)	not null,
	SingerTypeID	int	not null references SingerType(SingerTypeID),
	Gender	varchar(4)	check(Gender in ('��','Ů','���')),
	Photo	varchar(200)
)
go
--���������
create table SongType(
	SongTypeID int primary key identity(2001,1),
	SongTypeName	varchar(50)	not null
)
go
--������
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
--����Ա��
create table AdminInfo(
	AID int primary key identity(1,1),
	AName	Varchar(50)	not null,
	APwd	varchar(50)	not null
)
go

--��Դ�ļ���
create table ResourceUrl(
	RID int primary key identity(1,1),
	RName varchar(50) not null unique,
	RPath text not null
)
go
/*��Ӹ�������*/
insert into SingerType values('��½')
insert into SingerType values('��̨')
insert into SingerType values('ŷ��')
insert into SingerType values('�պ�')

/*��Ӹ�������*/
insert into SongType values('��������')
insert into SongType values('�����ϸ�')
insert into SongType values('Ӱ�ӽ���')
insert into SongType values('��Ϸ����')
insert into SongType values('����Ϸ��')
insert into SongType values('����')

/*��Ӹ���*/
insert into Singer values( 'Michael Jackson',1003,'��','Michael Jackson.jpg')
insert into Singer values( '����������',1004,'Ů','����������.jpg')
insert into Singer values( 'super junior',1003,'���','super junior.jpg')
insert into Singer values( '����Ԫ',1002,'��','����.jpg')
insert into Singer values( '��������',1004,'��','��������.jpg')
insert into Singer values( '������',1002,'��','����ͬ.jpg')
insert into Singer values( 'SHE',1002,'Ů','����ʫ.jpg')
insert into Singer values( '����к�',1003,'���','����к�.jpg')
insert into Singer values( '����',1001,'��','����.jpg')
insert into Singer values( '������',1001,'��','���һ.jpg')
insert into Singer values( '����',1004,'Ů','��Т��.jpg')
insert into Singer values( '���',1001,'Ů','���.jpg')
insert into Singer values( '�ֿϹ�԰',1003,'���','�ֿϹ�԰.jpg')
insert into Singer values( '��ӽ��',1001,'Ů','��Ӣ.jpg')
insert into Singer values( '�մ���',1002,'���','�մ���.jpg')
insert into Singer values( '��־��',1002,'Ů','������.jpg')
insert into Singer values( '����ʤ',1001,'��','Ѧ֮ǫ.jpg')
insert into Singer values( '�Ź���',1002,'��','�Ź���.jpg')
insert into Singer values( '������',1002,'��','��ѧ��.jpg')
insert into Singer values( '������',1002,'��','����ͼƬ.jpg')
insert into Singer values( '����',1001,'��','����.jpg')
insert into Singer values( '�׽���ʦ',1004,'��','�׽���ʦ.jpg')
insert into Singer values( '�ܽ���',1001,'��','�ܽ���.jpg')
insert into Singer values( 'Lukas Graham',1003,'��','lukas.jpg')
insert into Singer values( '�����',1001,'Ů','�����.jpg')
insert into Singer values( '������',1004,'Ů','������.jpg')
insert into Singer values( 'Ѧ֮ǫ',1002,'��','Ѧ֮ǫ.jpg')
insert into Singer values( '�Ժ�',1003,'Ů','�Ժ�.jpg')
insert into Singer values( '����Ⱥ��',1001,'��','default.jpg')
insert into Singer values( '˫��',1001,'Ů','˫��.jpg')
insert into Singer values( 'RIDWIMPS',1004,'��','RADWIMPS.jpg')
insert into Singer values( '������',1001,'��','������.jpg')
insert into Singer values( '��ѧ��',1001,'��','����ͼƬ.jpg')
insert into Singer values( '�ܫh',1002,'��','����ͼƬ.jpg')
insert into Singer values( 'Ī��ε',1002,'Ů','timg6OU13L29.jpg')
insert into Singer values( 'Ӣ������',1003,'���','fa941c0b43b1ece027e87f642e8dc4a067b6975b162ed-Upsjxa_fw658.jpg')
insert into Singer values( '�����ʥ������',1004,'���','thQL2ZPDU7.jpg')
insert into Singer values( '����������',1001,'���','timgEISEQIJ0.jpg')
insert into Singer values( '������',1001,'��','timg1.jpg')
insert into Singer values( '������',1001,'Ů','timgN9MS3300.jpg')
insert into Singer values( '���ֺ���',1001,'��','timgN9MS3300.jpg')
insert into Singer values( 'Goi7',1003,'��','timgB786XU8O.jpg')
insert into Singer values( 'The Verkkars',1003,'���','timg.jpg')
insert into Singer values( 'С����',1001,'��','С����.jpg')


/*����*/
--������ƴ�����������������ͣ����ֱ�ţ��ļ����������
insert into Song values ('7Years','7YEARS',6,2001,10,'7Years.mp4',0)
insert into Song values('EZ4ENCE','EZ4ENCE',7,2001,10,'EZ4ENCE.mp4',0)
insert into Song values('�������뿪�˱���������','NSNLKLBJDSH',11,2001,17,'�������뿪�˱���������.flv',0)
insert into Song values('LOSER','LOSER',5,2001,23,'LOSER.flv',0)
insert into Song values('С���','XQG',5,2001,15,'С���.flv',0)
insert into Song values('�����¿�','DNXK',4,2001,20,'�����¿�.flv',0)
insert into Song values('����','HT',2,2001,21,'����.flv',0)
insert into Song values ('����','LP',2,2002,1,'����.mp4',default)
insert into Song values('�ں�֮��','WHZZ',4,2001,2,'�ں�֮��.MP4',0)
insert into Song values('��ڻ���','YSHG',4,2003,2,'��ڻ���.mp4',0)
insert into Song values ('����','HL',2,2004,3,'����.mp4',0)
insert into Song values('��żʦ������֮��','ROSDYZZ',7,2006,4,'��żʦ������֮��.mp4',0)
insert into Song Values('˵�ò���','SHBK',4,2001,21,'˵�ò���.mp4',0)
insert into Song Values('��Ϊ��','HWM',3,2001,22,'��Ϊ��.avi',0)
insert into Song Values('��ҥ','MBY',3,2001,23,'��ҥ.mp4',0)
insert into Song Values('��ָ����','GZQS',4,2001,25,'��ָ����.avi',0)
insert into Song Values('�������','NDMZ',4,2001,24,'�������.mp3',0)
insert into Song Values('7Years','NDMZ',4,2001,24,'7Years.mp4',0)
insert into Song Values('������','NDMZ',4,2001,24,'������.mp4',0)
insert into Song values ('�Ǳ�','WB',2,2002,1,'wenbie.mp3',default)
insert into Song values('alarm','alarm',5,2001,2,'alarm.MP3',0)
insert into Song values('everybody','everybody',9,2001,8,'everybody.mp3',0)
insert into Song values ('�й���','ZGH',3,2001,7,'�й���.mp3',0)
insert into Song values('��Ҫ������','BYAST',5,2002,16,'��Ҫ������.wma',0)
insert into Song values('������㳡','BLGGC',5,2002,19,'������㳡.WMA',0)
insert into Song values ('��˵','CS',2,2002,19,'��˵.mp3',0)
insert into Song values('��������','DCLR',4,2003,10,'��������.mp3',0)
insert into Song values('�ڰ�','HB',2,2004,17,'�ڰ�.mp3',0)
insert into Song values('˵�ò���','SHBK',5,2001,20,'˵�ò���.mp4',0)
insert into Song values('��ҥ','MBY',3,2001,20,'��ҥ.avi',0)
insert into Song values('С���','XQG',3,2001,20,'�ܫh - С���.mp4',0)
insert into Song values('EZ4ENCE (kannatuslaulu)','EZ4ENCE',7,2001,9,'The Verkkars - EZ4ENCE (kannatuslaulu).mkv',default)
insert into Song values('�±��u','XBD',3,2001,3,'�����ʥ������ - �±��u.mkv',0)
insert into Song values('��������','CJXQ',4,2001,6,'������ - ��������.mp3',0)
insert into Song values('����','NP',2,2001,2,'Ӣ������ - ���� (Phoenix).mkv',0)
insert into Song values('Sunburst (����̨�ʰ�)','SUNBURST',13,2001,8,'Goi7 - Sunburst (����̨�ʰ�).mp3',0)
insert into Song values('��Ц����','DXJH',4,2001,47,'С���� - ��Ц����.mkv',0)
insert into Song values('�����̿�','JDCK',4,2001,4,'���������� - �����̿�.mkv',0)
insert into Song values('�ҹ��� (���Ұ�)','WGN',3,2001,5,'������ - �ҹ��� (���Ұ�).mkv',0)
insert into Song values('һ������','YSSA',4,2001,1,'¬��͢��Ī��ε - һ������.mkv',0)
insert into Song values('POPSTARS','POPSTARS',8,2001,2,'Ӣ������ - POPSTARS.mkv',0)
insert into Song values('7 Years','7YEARS',6,2001,7,'���ֺ��� - �����������׸�����һ���ᣬ��һ����Ҳ�š�7 Years��.mkv',0)


/*��ȡ��Դ*/
insert into ResourceUrl values('SingerPic','D:\MyKTV\SingerPhoto')		--����ͼƬ��ַ
insert into ResourceUrl values('SongPic','D:\MyKTV\SongPic')			--����ͼƬ��ַ
insert into ResourceUrl values('Song','D:\MyKTV\Song')					--�����ļ���ַ

/*��ӹ���Ա*/
insert into AdminInfo values('XYumi','020221')
insert into AdminInfo values('admin','123')
insert into AdminInfo values('����','666')
insert into AdminInfo values('��͹��','999')


--ɾ������
delete from Song where SongID = 49

--ɾ������
delete from Singer where SingerID =50

--�޸Ĺ���Ա��Ϣ
update AdminInfo set AName = '123', APwd = '321' where AID = 7
--��ʾ������Ϣ
select SongID, SongName, Songab, SongWordCount, a.SongTypeID,b.SingerName, c.SongTypeName, Url, ClientCount from song a, Singer b,SongType c where a.SingerID = b.SingerID and a.SongTypeID = c.SongTypeID
--��ʾ������Ϣ
select SingerID,SingerName,SingerTypeName,Gender,Photo from Singer,SingerType