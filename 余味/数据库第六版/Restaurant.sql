use master
--�������ݿ�
--if DB_ID('Restaurant') is not null
--  drop database Restaurant
--go
--  create database Restaurant
--  on
--  (
--     name='Restaurant',
--     filename='C:\Users\LXH\Desktop\��ζ���ϵͳ\Restaurant.MDF'
--  )
  
-- go
create database Restaurant

--�л����ݿ�
use Restaurant

--������Ʒ���ͱ�
if OBJECT_ID('CarTFdisTypeype') is not null
   drop table FdisType
 go
create table FdisType
(
	FypeId int primary key identity(1,1),			--����id
	Fname  varchar(20) not null			--��������
)
insert into FdisType values('�ҳ���ɫ��')
insert into FdisType values('������')
insert into FdisType values('�����')
insert into FdisType values('�ϻ�������')
insert into FdisType values('��ʳ��')
insert into FdisType values('������')
insert into FdisType values('��ˮ��')
insert into FdisType values('��ˮ��')
select top 100 * from FdisType
--������Ʒ��
if OBJECT_ID('Menu') is not null
   drop table Menu
 go
create table Menu
(
	MeId int primary key identity(001,1),									--��Ʒid
	MeName varchar(50) not null,											--��Ʒ����
	MePrice money not null,													--��Ʒ�۸�	
	FypeId int foreign key(FypeId) references FdisType(FypeId),				--��Ʒ����
	MPicture image ,														--��ƷͼƬ
	MeTerial varchar(50) not null,											--��Ʒ����	��Ҫ����
	MeTaste varchar(50)  not null,											--��Ʒ��ζ	
	MeDetails varchar(500) not null,										--��Ʒ����
	MeNumber int,															--��Ʒ����
)
insert into Menu values('�ع���',128,1,'','�������������������˿','΢��','�ع�����һ���������ˣ��ع�����Դ���ձ���³�Ͻ��紦��΢ɽ������')
insert into Menu values('���Ŷ���',58,1,'','����','����','���Ŷ������ҹ��˴��ϵ֮һ�Ĵ����е���Ʒ����Ҫԭ���ɶ������ɣ�����ɫ�����顢�����̡��㡢�֡��ۡ��ʡ�����֣���֮Ϊ��������')
insert into Menu values('�ҳ�������',58,1,'','���ӡ��������л�','΢��','������һ�ַǳ������ҳ����߲ˣ���Ȼһ���ļ����У������ڹ㶫��������óԵļ��ھ��ڳ��ģ�������������ӣ�ζŨ�����㣬���ʵ������Ӫ���ḻ�����������ܼ���ѪѹѪ֬����˥�ϣ����Ƚⶾ���ṩ�����˵�')
insert into Menu values('��������',68,1,'','���㡢�������ɺ�����','��','��ɫ���㡢��ζ�������ɿڣ��ʶ�����')
insert into Menu values('���Ƽ�',68,1,'','ĸ����������','΢������','ɫ�󰵺죬��ζ�����̲�����')
insert into Menu values('�Ǵ��Ｙ',48,1,'','�Ｙ�⣬���ѽ������������','����','����ɿڣ�����ʳ���󿪣��ò�Ʒ���²ˡ�ԥ�ˡ���ˡ�³�ˡ����ˡ�����ˡ����ˡ���������д˲�')
insert into Menu values('���м�',68,1,'','����','������ζ','��ն�������̣�ʼ�����������¥�����뼦ʱ���ӵ�ζ������ɣ��㶫ʡ��Զ����ɽ�س�Ʒ�����Ƽ����Żơ�Ƥ�ơ���ƣ������ֳ������ͼ�')
insert into Menu values('��ʽ�ն�',168,1,'��ʽ�ն�.jpg','��','��','��ʽ�ն죬����ϵ���ǹ��ݴ�ͳ���տ���ʳ����˵�Ѿ���700�������ʷ�ˣ�����������ն���Ϊ�������ն�Ƥ�ڸ��Ƿǳ���ģ����������ܵ���ǡ�����Ҫ���ۻ���֭���ʶ�����')
insert into Menu values('������',58,1,'������','С����','Ƥ������','ɫ�������̬������Ƥ�����ۣ��ʶ����壬�������ۣ��������')
insert into Menu values('�������',48,1,'�������.jpg','���','����','���յ�����������ۣ��Ժ�����룬����Ӫ���ḻ����������,�󲿷���������ͷҲ���Ź�����Ϊ����±������ը���������㵽�������')
insert into Menu values('��֭����',48,1,'��֭����.jpg','����','����','��֭������2018��9��10�շ����ġ��й��ˡ�֮һ�����в�����Ѫ����������������Ӽ������ͽ��ԵĹ�Ч')
insert into Menu values('�����',59,1,'�����.jpg','�Ź�','���㣬����','��������')
insert into Menu values('���ܹ�����',49,1,'���ܹ�����.jpg','���ܣ������⣬���������ѽ�','����΢��','�����⣬���������⡣��һ���㶫����ɫ����,��ʱ�е��ԣ�����ʱ�п�����,����ɿ�')
insert into Menu values('�ɳ�ţ��',38,1,'�ɳ�ţ��.jpg','�ӷۡ�ţ�⡢��','���ʿɿڣ�����','�ɳ�ţ��ɫ����������ţ�⻬�۽��㡢�ӷ�ˬ����������и�ˬ��֭���������ζ�������϶����ḻ')
insert into Menu values('����ƹϸ���ľ��',28,2,'����ƹϸ���ľ��.jpg','�ƹϡ�����ľ��','����΢��','ˬ�ڿ�θ')
insert into Menu values('�����޹Ƿ�צ',48,2,'�����޹Ƿ�צ.jpg','��צ������','��','���ˬ��')
insert into Menu values('����ݫ��',28,2,'����ݫ��.jpg','ݫ������','����΢��','ˬ�ڿ�θ')
insert into Menu values('����ƹϸ���ľ��',28,2,'����ƹϸ���ľ��.jpg','�ƹϡ�����ľ��','����΢��','ˬ�ڿ�θ')
insert into Menu values('������Ƥ',38,2,'������Ƥ.jpg','��Ƥ������','΢��','���ˬ��')
insert into Menu values('������',38,3,'������.jpg','��ˡ����⡢����','�ҳ�ζ','�ҵ�ζ��')
insert into Menu values('�������',38,3,'�������.jpg','��ˡ����','�ҳ�ζ','����Ե�̫���������嵭�ģ�ȥ֬���ʣ������ˣ���򵥵�ȥ֬���ʲ�')
insert into Menu values('˿�ϳ���Ѽ��',38,3,'˿�ϳ���Ѽ��.jpg','˿�ϡ���Ѽ��','�ҳ�ζ','���ˬ��')
insert into Menu values('��ݻ�ɽҩ�ϼ���',58,4,'��ݻ�ɽҩ�ϼ���.jpg','��ݻ����ϼ���ɽҩ','�ҳ�ζ','��ݻ����зḻ�ĵ����ʣ�����ǿ�͵����������߹��ܡ�������忹��������һ�������á���������������衢ֹѪ��̵�Ĺ�Ч���ܽ����������������ˣ�ζ���ǳ�Ũ��')
insert into Menu values('�����ڼ���',48,4,'�����ڼ���.jpg','�������ڼ�������','�ҳ�ζ','��������θ��Ƣ������ǿ����ۡ�Ӫ��������ʳ�������ߡ�Ƥ���ֲڵȾ��в����ʳ�ƹ�ЧŶ')
insert into Menu values('ɽҩ�Ź���',48,4,'ɽҩ�Ź���.jpg','ɽҩ���Źǡ���轡�ë��','�ҳ�ζ','ɽҩ������кܺõ�������Ч���Źǵ���ζ������˵������ë�����ܲ�����ʡ��ǲ�������ļҳ���Ʒ')
insert into Menu values('���鵳���ڼ���',58,4,'���鵳���ڼ���.jpg','���Ρ����顢�����ӡ����Ρ��ٺϡ����桢�����','�ҳ�ζ','���鵳���ڼ�����һ��ǳ��ʺ���Ѫ���㡢Ƥ�����ơ���������������ƣ����ͷ�ε���ʿ�ճ���������ϣ������ر�Ů���������ر������ǰ��������')
insert into Menu values('�˲μ���',58,4,'�˲μ���.jpg','��ĸ�����˲Ρ����ӡ������','�ҳ�ζ','�μ�����һ�����˲Ρ�ͯ�Ӽ���Ŵ���ҳɵ��й����ϵĹ㶫��������ҳ���֮һ�������������Ϊ��ߴ����Եĺ�����������֮һ')
insert into Menu values('��������Ѽ��',58,4,'��������Ѽ��.jpg','��Ѽ������������','�ҳ�ζ','��θ������ֹŻ����̵ֹ�ȡ�ɢ�����')
insert into Menu values('���׷�',3,5,'̩������.jpg','����','����','������Ө��͸����������Ʈ�磬Ӫ���ḻ')
insert into Menu values('�½�����',15,5,'�½�����.jpg','���桢���ѡ�����','����','�½��İ���Ӳ��ʵ��,����������齺������;�,������������������ʵ��,������,��ܾ��񻹿���')
insert into Menu values('�²��������',20,5,'�²��������.jpg','�²ˡ�������','�²����������һ����ͳС�ԣ��������ʳƷ')
insert into Menu values('���ջƻ���',48,6,'���ջƻ���.jpg','�ƻ��㡢������������������','����','���ջƻ����������ˣ���һ���ҳ��ˡ������ǻƻ��㣬������ˡ���������ƶ��ɡ��ƻ��㺬�ḻ�ĵ����ʺ�ά���أ�����������Ӧ��ʳ')
insert into Menu values('�������ǰ�',688,6,'�������ǰ�.jpg','Ұ�����ǰߡ��ƾơ�����','���ۡ�Q��','���������˱ǣ�����ɫ���������������΢�������۵Ĳ�θ�')
insert into Menu values('�����h��Ϻ',488,6,'�����h��Ϻ.jpg','��ʿ�ٴ���Ϻ������','���ۡ�Q��','��Ʒ���ʽ��ϸ�ۣ�ζ�������������ʺ����ߣ�֬�������ͣ�Ӫ���ḻ���ر��ʺ��̲�ʳ��')
insert into Menu values('����Ϻ',188,6,'����Ϻ.jpg','��Ϻ����Ƭ','���ۡ�Q��','����Ϻ��һ����ͳ���ˡ�������ϲ���ð���֮������Ϻ��Ϊ���Ǳ������ʡ����۵�ԭζ��Ȼ��Ϻ����պ��֭��ʳ')
insert into Menu values('������������',288,6,'������������.jpg','�Źǡ�����з����Ϻ�����ۡ���֦','����','�������������Ĺ�Ч��θֹŻ������Ƣθ�麮����ķ�������Ż�£������ͣ��ǿ����𵽸���Ч����')
insert into Menu values('����������ѩ��',36,7,'����������ѩ��.jpg','ѩ�桢���ǡ�����','��Ʒ','ֹ�ȣ��ⶾ')
insert into Menu values('�̶�ɳ',15,7,'�̶�ɳ.jpg','�̶�������','��Ʒ','�̶������Ȱܶ���������ˮ����Ϊ���ʢ�е�����ʳƷ֮һ')
insert into Menu values('����ˬ',15,7,'����ˬ.jpg','���㡢���ǡ�ź��','��Ʒ','���зḻ��Ӫ��������ķ�ζ')
insert into Menu values('Ҭ֭��������',38,7,'Ҭ֭��������.jpg','Ҭ֭�����ǡ�����','��Ʒ','Ҭ֭���������ǹ㶫�Ĵ�ͳ���㣬��������ϵ')
select top 100 * from Menu
select top 10 * from  Menu where MeName = '�ع���'


select top 100 A.MeName,A.MePrice,B.Fname,A.MPicture,A.MeTerial,A.MeTaste,A.MeDetails,A.MeNumber from Menu A,FdisType B where A.FypeId = B.FypeId and Fname = '�ҳ���ɫ��'


delete from Menu where MeName ='Ҭ֭��������'
--����Ա����
create table Employee
(
	EmId int primary key identity(1001,1),									--Ա��id	
	EmCount varchar(20)not null,								--Ա���˺�
	EmPwd varchar(20)not null,									--Ա������
	EmName varchar(20) not null,								--Ա������
	EmAge int not null,											--Ա������
	EmSex char(2) check(EmSex='��' or EmSex='Ů') not null,		--Ա���Ա�
	EmPhone varchar(11) not null,								--Ա���绰
	EmCid varchar(18) not null,									--Ա�����֤
	EmAddress varchar(100) not null,							--Ա��סַ
	EmWages  money not null,									--Ա������
	EmTion  varchar(20) not null,								--Ա��ְλ
	EmState	varchar(4) check(EmState='�ݼ�' or EmState='�ڸ�' or EmState='��ְ')	--״̬
	
	
)
select top 100 EmCount,EmPwd,EmTion from Employee where EmCount = '1' and EmPwd ='12' and EmTion ='����'
select *  from Employee
insert into Employee values('werdrfdftf','12344321','����',25,'��','13102007389','440903200298748391','�㶫ʡ�麣�вƸ�����',4888,'����','�ڸ�')
insert into Employee values('jhdsrfdftf','12039281','����',23,'��','13124547389','440573927495829391','�㶫ʡ�麣�вƸ�����',4888,'����','�ڸ�')
insert into Employee values('fdawcbvztf','14658381','����',23,'��','13000928199','445745654799070796','�㶫ʡ�麣�вƸ�����',4888,'����','�ڸ�')
insert into Employee values('ntytrbvpoe','10695831','����',25,'��','13647382689','440980700979796966','�㶫ʡ�麣�вƸ�����',4888,'����','�ڸ�')
insert into Employee values('bnmjdiaeui','11274721','����',25,'��','11244342429','440789686585976968','�㶫ʡ�麣�вƸ�����',4888,'����','�ڸ�')
insert into Employee values('iwuuuajeai','10294828','����',24,'��','16436743259','440457633464365791','�㶫ʡ�麣�вƸ�����',4888,'����Ա','�ڸ�')
insert into Employee values('bnnbbbzjsk','11123131','�Ͼ�',23,'��','11232421430','440009776667876556','�㶫ʡ�麣�вƸ�����',4888,'����Ա','�ڸ�')
insert into Employee values('bcnzmzkiqk','15252525','����',23,'Ů','17854638532','440632252522231143','�㶫ʡ�麣�вƸ�����',4888,'����Ա','�ڸ�')
insert into Employee values('uuywiqorox','75757576','��ϼ',23,'Ů','10908753324','441112414242114626','�㶫ʡ�麣�вƸ�����',4888,'����Ա','�ڸ�')
insert into Employee values('jajxnzzmxn','98989898','��ϼ',22,'Ů','14324254565','449556356543456756','�㶫ʡ�麣�вƸ�����',4588,'����Ա','�ڸ�')
insert into Employee values('pqoaiwjmxb','00000009','������',23,'Ů','13124141098','440009770987656536','�㶫ʡ�麣�вƸ�����',4588,'����Ա','�ڸ�')
insert into Employee values('lkdkjxnbzm','01313409','������',23,'Ů','12233533538','440009098747282117','�㶫ʡ�麣�вƸ�����',4588,'����Ա','�ڸ�')
insert into Employee values('mncbzcbvzn','00222209','����',23,'Ů','11125678898','440009772663888889','�㶫ʡ�麣�вƸ�����',4588,'����Ա','�ڸ�')
insert into Employee values('pzemzienqy','75300009','������',24,'Ů','10008764670','447776361837181193','�㶫ʡ�麣�вƸ�����',4588,'����Ա','�ڸ�')
insert into Employee values('truxurnxia','08443631','����',23,'Ů','10092847261','447758282849210536','�㶫ʡ�麣�вƸ�����',4588,'����Ա','�ڸ�')
insert into Employee values('lznjhjsuwu','11111111','���',25,'��','13185772629','440906472612738389','�㶫ʡ�麣�вƸ�����',5888,'����','�ڸ�')
insert into Employee values('zqiwisnawa','12909753','����',25,'Ů','12139483389','448837173774626362','�㶫ʡ�麣�вƸ�����',5888,'����','�ڸ�')


--��ѯ
select COUNT(EmTion) from Employee 


--��������/�����
create table Ramadhins
(
	Rid int primary key identity(1,1) ,								--����id
	Radhin varchar(10),									--����/�����  001...050..100 / A001...A50
	Rtate varchar(5),									--״̬	
)
select * from Ramadhins
update Ramadhins set  Radhin = '009' where Radhin = '09'
insert into Ramadhins values('A01','��')
insert into Ramadhins values('A02','��')
insert into Ramadhins values('A03','��')
insert into Ramadhins values('A04','��')
insert into Ramadhins values('A05','��')
insert into Ramadhins values('A06','��')
insert into Ramadhins values('A07','��')
insert into Ramadhins values('A08','��')
insert into Ramadhins values('A09','��')
insert into Ramadhins values('A10','��')
insert into Ramadhins values('A11','��')
insert into Ramadhins values('A12','��')
insert into Ramadhins values('A13','��')
insert into Ramadhins values('A14','��')
insert into Ramadhins values('A15','��')
insert into Ramadhins values('A16','��')
insert into Ramadhins values('A17','��')
insert into Ramadhins values('A18','��')
insert into Ramadhins values('A19','��')
insert into Ramadhins values('A20','��')
insert into Ramadhins values('A21','��')
insert into Ramadhins values('A22','��')

insert into Ramadhins values('����ͤ','��')
insert into Ramadhins values('����ͤ','��')
insert into Ramadhins values('��ˮͤ','��')
insert into Ramadhins values('¶��ͤ','��')
insert into Ramadhins values('����ͤ','��')
insert into Ramadhins values('����ͤ','��')
insert into Ramadhins values('����ͤ','��')
insert into Ramadhins values('����ͤ','��')
insert into Ramadhins values('��ϼͤ','��')
insert into Ramadhins values('����ͤ','��')
insert into Ramadhins values('����ͤ','��')

select * from Ramadhins

DROP TABLE Ramadhins

--������Ա��
create table Menber
(
	MenberId int primary key identity(1,1),											--��Աid
	MeMember int check(MeMember>=3 and MeMember<=0),					--��Ա�ȼ�
	Meintegral int not null,											--��Ա����
)
insert into Menber values(3,550)
insert into Menber values(2,300)
insert into Menber values(1,150)





--������Ӧ�̱�
create table supplier
(
	[Sid] int primary key identity(101,1),					--��Ӧ��id
	Sname varchar(100) not null,							--��Ӧ������
	Sphone varchar(15) not null,							--��Ӧ�̵绰
	Saddress varchar(100) not null,							--��Ӧ�̵�ַ

)
insert into supplier values('�麣�н���ũ����Ʒ���޹�˾','15412439188',' �㶫ʡ�麣������������·65��ǰɽ��ó��������3435��')
insert into supplier values('�麣�е�һ���޹�˾','0756-2293841','�麣��������Ϫ·������ó���ײ�')
insert into supplier values('��ɽ�����ˮ�����޹�˾','18676186325','��ɽ��ɳϪ���ɽ��Ȼ�½�����1��1¥1��')
insert into supplier values('�麣��Դ����ũ��Ʒ���޹�˾','121443675321','�麣������������һ·5��2��һ¥�ۺϹ�������A16��')
insert into supplier values('�麣�к�Դʢ�߲˹�Ʒ���޹�˾','13332261888','�麣������������һ·5��2����������԰һ¥��37��')
insert into supplier values('����ę́ר����','(0756)8883169','�㶫ʡ�麣��������������·288��һ��113��֮������')
insert into supplier values('����Һ(��ɽ·��)','(0756)2618466','�麣����������ɽ·������л�԰')


select * from supplier

--������Ʒ��
create table Goods
(
	Gid int primary key identity(1001,1),											--��Ʒid
	Gname varchar(20) not null,										--��Ʒ����
	Gprice money not null,											--��Ʒ�۸�
	Gtione varchar(5) not null,										--��Ʒ���
	[Sid] int foreign key ([Sid]) references supplier([Sid]) not null,	--������id
	Gnumber int not null,											--��Ʒ����
	
)
insert into supplier values('������',288,'250ml','����Һ(��ɽ·��)',20)
insert into supplier values('ę́',3888,'375ml','����ę́ר����',15)
insert into supplier values('���ϴ�',488,'500ml','����Һ(��ɽ·��)',15)
insert into supplier values('�ھ�',388,'375ml','����Һ(��ɽ·��)',20)
insert into supplier values('����',888,'500ml','����ę́ר����',15)
insert into supplier values('�ž�����',688,'500ml','����ę́ר����',10)
insert into supplier values('������',288,'500ml','����Һ(��ɽ·��)',10)



select  * from Menu where  FypeId = 3


--�������ű�
create table Number 
(
	Nid int primary key identity(1,1 ),		--����id    
	BiNumber varchar(50) unique ,			--����
	Radhin varchar(20)not null,				--����
	Nstate int default'0' not null,			--״̬	
)

update Number  set BiNumber='No.000001',Radhin=1,Nstate=4 where Nid = 1
insert into Number values('No.000018','A17',0)

select top 100*from Number 
drop table Number
	drop table Bill
	
	select top 100 * from Number where Nstate='5'and Radhin=0
--�����˵���
create table Bill
(
	Bid int identity(1,1),												--�˵�id
	Nid int foreign key (Nid) references Number(Nid) not null,			--�˵����
	Radhin varchar(20) null ,											--����id
	MeName varchar(20) not null,										--��Ʒ
	MeNumber int not null,												--��Ʒ����
	Btaste varchar(50),													--��ζ
	Bnote  varchar(1000),												--��ע
	BiPrice money not null,												--�ܽ��
	Btime  Datetime not null,											--�µ�����
)
SELECT * FROM Number
select top 100 *from Bill A,Number B where A.Nid = B.Nid 
insert	into Bill values(3,1,2,'fafds','312',256,'2020-1-1')
******
insert	into Bill values(4,1,2,256,'4132','32141',123,'2020-1-1'),(7,1,1,128,'4321','14312',123,'2020-1-1')

update Bill set Bid=2,'A02','���׷�',2,'΢��',1,7,'2002-6-18' where Bid ='2'

select top 100 * from Bill where Radhin='014'

select top 100 * from Bill A,Number B where A.Nid = B.Nid and A.MeName = '���׷�' and B.Radhin = 'A02'
*

drop table Bill

delete from Bill where Radhin = '014' and BiPrice = '110'

--����id������ʱ�䣬Ա��id��

--�������ڱ�
create table Rcheck
(
	Rid int identity(1,1),
	Rdate datetime not null,
	EmId int foreign key (EmId) references Employee(EmId)not null,	--Ա��id
)


--�޸��˵����洢����
if OBJECT_ID('UpdateBillInfo')is not null
	drop proc UpdateBillInfo
go
	create proc UpdateBillInfo
	@Bid int,
	@Nid int,
	@Radhin varchar(20),
	@MeName varchar(20),
	@MeNumber int,
	@Btaste varchar(50),
	@Bnote varchar(1000),
	@BiPrice money,
	@Btime datetime
as
	update Bill set Nid=@Nid,Radhin=@Radhin,MeName=@MeName,MeNumber=@MeNumber,Btaste=@Btaste,
	Bnote=@Bnote,BiPrice=@BiPrice,Btime=@Btime where Bid = @Bid
go

exec UpdateBillInfo 1,2,'A02','С��',2,'����',1,8,'2002-6-18'

select * from Bill