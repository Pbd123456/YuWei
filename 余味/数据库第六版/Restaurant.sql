use master
--创建数据库
--if DB_ID('Restaurant') is not null
--  drop database Restaurant
--go
--  create database Restaurant
--  on
--  (
--     name='Restaurant',
--     filename='C:\Users\LXH\Desktop\余味点餐系统\Restaurant.MDF'
--  )
  
-- go
create database Restaurant

--切换数据库
use Restaurant

--创建菜品类型表
if OBJECT_ID('CarTFdisTypeype') is not null
   drop table FdisType
 go
create table FdisType
(
	FypeId int primary key identity(1,1),			--类型id
	Fname  varchar(20) not null			--类型名称
)
insert into FdisType values('家常特色菜')
insert into FdisType values('凉菜类')
insert into FdisType values('青菜类')
insert into FdisType values('老火靓汤类')
insert into FdisType values('主食类')
insert into FdisType values('海鲜类')
insert into FdisType values('糖水类')
insert into FdisType values('酒水类')
select top 100 * from FdisType
--创建菜品表
if OBJECT_ID('Menu') is not null
   drop table Menu
 go
create table Menu
(
	MeId int primary key identity(001,1),									--菜品id
	MeName varchar(50) not null,											--菜品名称
	MePrice money not null,													--菜品价格	
	FypeId int foreign key(FypeId) references FdisType(FypeId),				--菜品类型
	MPicture image ,														--菜品图片
	MeTerial varchar(50) not null,											--菜品主料	主要配料
	MeTaste varchar(50)  not null,											--菜品口味	
	MeDetails varchar(500) not null,										--菜品详情
	MeNumber int,															--菜品销量
)
insert into Menu values('地锅鸡',128,1,'','公鸡、辣椒、面饼、粉丝','微辣','地锅鸡是一道汉族名菜，地锅菜起源于苏北和鲁南交界处的微山湖地区')
insert into Menu values('麻婆豆腐',58,1,'','豆腐','麻辣','麻婆豆腐是我国八大菜系之一的川菜中的名品。主要原料由豆腐构成，其特色在于麻、辣、烫、香、酥、嫩、鲜、活八字，称之为八字箴言')
insert into Menu values('家常烧茄子',58,1,'','茄子、辣椒、葱花','微辣','茄子是一种非常常见家常的蔬菜，虽然一年四季都有，但是在广东，茄子最好吃的季节就在初夏，新苗初长的茄子，味浓，清香，肉厚实。茄子营养丰富，常吃茄子能减低血压血脂，抗衰老，清热解毒，提供免疫了等')
insert into Menu values('花椒猪蹄',68,1,'','猪蹄、花椒、干红辣椒','麻','特色猪蹄、其味道香辣可口，肥而不腻')
insert into Menu values('秘制鸡',68,1,'','母鸡、板蓝根','微甜、清凉','色泽暗红，口味醇厚，滋补养身')
insert into Menu values('糖醋里脊',48,1,'','里脊肉，番茄酱，鸡蛋，面粉','酸甜','酸甜可口，让人食欲大开；该菜品在陕菜、豫菜、浙菜、鲁菜、川菜、淮扬菜、粤菜、闽菜里均有此菜')
insert into Menu values('白切鸡',68,1,'','公鸡','葱油香味','白斩鸡是冷盘，始于清代的民间酒楼，因烹鸡时不加调味白煮而成，广东省清远市阳山县出品的三黄鸡（脚黄、皮黄、嘴黄），故又称三黄油鸡')
insert into Menu values('广式烧鹅',168,1,'广式烧鹅.jpg','鹅','咸','广式烧鹅，粤菜系，是广州传统的烧烤美食，据说已经有700多年的历史了，其中又以深井烧鹅最为出名，烧鹅皮口感是非常脆的，吃着像冰淇淋的外壳。鹅肉要求嫩滑多汁，肥而不腻')
insert into Menu values('烤乳猪',58,1,'烤乳猪','小乳猪','皮酥肉嫩','色泽红润，形态完整，皮酥肉嫩，肥而不腻，又鲜又嫩，入口奇香')
insert into Menu values('红烧乳鸽',48,1,'红烧乳鸽.jpg','乳鸽','咸香','红烧的乳鸽外酥里嫩，吃红烧乳鸽，鸽肉营养丰富，易于消化,大部分人是连骨头也不放过，因为经过卤煮再油炸的乳鸽的是香到骨子里的')
insert into Menu values('蜜汁叉烧',48,1,'蜜汁叉烧.jpg','猪肉','香甜','蜜汁叉烧是2018年9月10日发布的“中国菜”之一，具有补肾养血，滋阴润燥和有增加记忆力和健脑的功效')
insert into Menu values('蒜香骨',59,1,'蒜香骨.jpg','排骨','蒜香，略辣','外酥里嫩')
insert into Menu values('菠萝咕噜肉',49,1,'菠萝咕噜肉.jpg','菠萝，猪瘦肉，鸡蛋，番茄酱','酸甜、微辣','咕噜肉，又名古老肉。是一道广东的特色名菜,吃时有弹性，嚼肉时有咯咯声,酸甜可口')
insert into Menu values('干炒牛河',38,1,'干炒牛河.jpg','河粉、牛肉、葱','咸鲜可口，麻辣','干炒牛河色泽油润亮泽、牛肉滑嫩焦香、河粉爽滑筋道、盘中干爽无汁、入口鲜香味美、配料多样丰富')
insert into Menu values('凉拌黄瓜腐竹木耳',28,2,'凉拌黄瓜腐竹木耳.jpg','黄瓜、腐竹、木耳','清甜微辣','爽口开胃')
insert into Menu values('酸辣无骨凤爪',48,2,'酸辣无骨凤爪.jpg','鸡爪、辣椒','辣','清脆爽口')
insert into Menu values('凉拌莴笋',28,2,'凉拌莴笋.jpg','莴笋、辣椒','清甜微辣','爽口开胃')
insert into Menu values('凉拌黄瓜腐竹木耳',28,2,'凉拌黄瓜腐竹木耳.jpg','黄瓜、腐竹、木耳','清甜微辣','爽口开胃')
insert into Menu values('凉拌鱼皮',38,2,'凉拌鱼皮.jpg','鱼皮、辣椒','微辣','清脆爽口')
insert into Menu values('青菜香干',38,3,'青菜香干.jpg','青菜、猪肉、豆干','家常味','家的味道')
insert into Menu values('耗油青菜',38,3,'耗油青菜.jpg','青菜、蚝油','家常味','过年吃的太油腻来点清淡的，去脂减肥，蚝油青菜，简简单单去脂减肥菜')
insert into Menu values('丝瓜炒咸鸭蛋',38,3,'丝瓜炒咸鸭蛋.jpg','丝瓜、咸鸭蛋','家常味','清脆爽口')
insert into Menu values('虫草花山药老鸡汤',58,4,'虫草花山药老鸡汤.jpg','虫草花、老鸡、山药','家常味','虫草花含有丰富的蛋白质，对增强和调节人体免疫功能、提高人体抗病能力有一定的作用。有益肝肾、补精髓、止血化痰的功效。很健康的汤，老少咸宜，味道非常浓郁')
insert into Menu values('栗子乌鸡汤',48,4,'栗子乌鸡汤.jpg','板栗、乌鸡、红枣','家常味','鸡汤对养胃健脾、补肾强筋、干眼、营养不良、食欲不振者、皮肤粗糙等均有不错的食疗功效哦')
insert into Menu values('山药排骨汤',48,4,'山药排骨汤.jpg','山药、排骨、枸杞、毛豆','家常味','山药和枸杞有很好的养肾功效，排骨的美味更不用说，搭配毛豆更能补充钙质。是补肾固身的家常良品')
insert into Menu values('当归党参乌鸡汤',58,4,'当归党参乌鸡汤.jpg','党参、当归、白莲子、黄芪、百合、红枣、枸杞子','家常味','当归党参乌鸡汤是一款非常适合气血不足、皮肤暗黄、手足无力、容易疲倦与头晕的人士日常调理的汤料，更是特别女性朋友在特别的日子前后补养身体')
insert into Menu values('人参鸡汤',58,4,'人参鸡汤.jpg','老母鸡、人参、栗子、枸杞子','家常味','参鸡汤是一道以人参、童子鸡和糯米煲成的中国古老的广东粤菜汤类家常菜之一，传至韩国后成为最具代表性的韩国宫中料理之一')
insert into Menu values('茶树菇老鸭汤',58,4,'茶树菇老鸭汤.jpg','老鸭、茶树菇、姜','家常味','开胃、降逆止呕、化痰止咳、散寒解表')
insert into Menu values('白米饭',3,5,'泰国香米.jpg','香米','香甜','颗粒晶莹，透明如玉，米香飘溢，营养丰富')
insert into Menu values('新疆拌面',15,5,'新疆拌面.jpg','拉面、番茄、辣椒','酸辣','新疆的拌面硬的实在,嘴里嚼着有乳胶条般的韧劲,进到肚里像死面馍样实诚,吃着起劲,振奋精神还抗饿')
insert into Menu values('韭菜猪肉饺子',20,5,'韭菜猪肉饺子.jpg','韭菜、瘦猪肉','韭菜猪肉饺子是一道传统小吃，属于年节食品')
insert into Menu values('红烧黄花鱼',48,6,'红烧黄花鱼.jpg','黄花鱼、红辣椒、花椒、大蒜','香辣','红烧黄花鱼属于粤菜，是一道家常菜。主料是黄花鱼，配以青菜、猪肉等烧制而成。黄花鱼含丰富的蛋白质和维生素，体质虚弱者应多食')
insert into Menu values('清蒸东星斑',688,6,'清蒸东星斑.jpg','野生东星斑、黄酒、酱油','鲜嫩、Q弹','葱香鱼香扑鼻，并且色泽鲜亮，入口有由微焦至极嫩的层次感')
insert into Menu values('上汤焗龙虾',488,6,'上汤焗龙虾.jpg','波士顿大龙虾、上汤','鲜嫩、Q弹','本品肉质洁白细嫩，味道鲜美，蛋白质含量高，脂肪含量低，营养丰富。特别适合滋补食用')
insert into Menu values('白灼虾',188,6,'白灼虾.jpg','鲜虾、姜片','鲜嫩、Q弹','白灼虾是一道传统名菜、广州人喜欢用白灼之法来做虾，为的是保持其鲜、甜、嫩的原味，然后将虾剥壳蘸酱汁而食')
insert into Menu values('冬阴功海鲜汤',288,6,'冬阴功海鲜汤.jpg','排骨、梭子蟹、鲜虾、蛤蜊、花枝','鲜嫩','冬阴功海鲜汤的功效养胃止呕，用于脾胃虚寒引起的反复恶心呕吐，肚子胀，是可以起到辅助效果的')
insert into Menu values('冰糖银耳炖雪梨',36,7,'冰糖银耳炖雪梨.jpg','雪梨、冰糖、银耳','甜品','止咳，解毒')
insert into Menu values('绿豆沙',15,7,'绿豆沙.jpg','绿豆、冰糖','甜品','绿豆能清热败毒，消暑利水，故为民间盛行的夏令食品之一')
insert into Menu values('马蹄爽',15,7,'马蹄爽.jpg','马蹄、冰糖、藕粉','甜品','具有丰富的营养和特殊的风味')
insert into Menu values('椰汁冰糖燕窝',38,7,'椰汁冰糖燕窝.jpg','椰汁、冰糖、燕窝','甜品','椰汁冰糖燕窝是广东的传统名点，属于粤菜系')
select top 100 * from Menu
select top 10 * from  Menu where MeName = '地锅鸡'


select top 100 A.MeName,A.MePrice,B.Fname,A.MPicture,A.MeTerial,A.MeTaste,A.MeDetails,A.MeNumber from Menu A,FdisType B where A.FypeId = B.FypeId and Fname = '家常特色菜'


delete from Menu where MeName ='椰汁冰糖燕窝'
--创建员工表
create table Employee
(
	EmId int primary key identity(1001,1),									--员工id	
	EmCount varchar(20)not null,								--员工账号
	EmPwd varchar(20)not null,									--员工密码
	EmName varchar(20) not null,								--员工姓名
	EmAge int not null,											--员工年龄
	EmSex char(2) check(EmSex='男' or EmSex='女') not null,		--员工性别
	EmPhone varchar(11) not null,								--员工电话
	EmCid varchar(18) not null,									--员工身份证
	EmAddress varchar(100) not null,							--员工住址
	EmWages  money not null,									--员工工资
	EmTion  varchar(20) not null,								--员工职位
	EmState	varchar(4) check(EmState='休假' or EmState='在岗' or EmState='离职')	--状态
	
	
)
select top 100 EmCount,EmPwd,EmTion from Employee where EmCount = '1' and EmPwd ='12' and EmTion ='经理'
select *  from Employee
insert into Employee values('werdrfdftf','12344321','张三',25,'男','13102007389','440903200298748391','广东省珠海市财富世家',4888,'传菜','在岗')
insert into Employee values('jhdsrfdftf','12039281','李四',23,'男','13124547389','440573927495829391','广东省珠海市财富世家',4888,'传菜','在岗')
insert into Employee values('fdawcbvztf','14658381','王五',23,'男','13000928199','445745654799070796','广东省珠海市财富世家',4888,'传菜','在岗')
insert into Employee values('ntytrbvpoe','10695831','赵六',25,'男','13647382689','440980700979796966','广东省珠海市财富世家',4888,'传菜','在岗')
insert into Employee values('bnmjdiaeui','11274721','刘七',25,'男','11244342429','440789686585976968','广东省珠海市财富世家',4888,'传菜','在岗')
insert into Employee values('iwuuuajeai','10294828','王八',24,'男','16436743259','440457633464365791','广东省珠海市财富世家',4888,'操作员','在岗')
insert into Employee values('bnnbbbzjsk','11123131','老九',23,'男','11232421430','440009776667876556','广东省珠海市财富世家',4888,'操作员','在岗')
insert into Employee values('bcnzmzkiqk','15252525','刘欢',23,'女','17854638532','440632252522231143','广东省珠海市财富世家',4888,'操作员','在岗')
insert into Employee values('uuywiqorox','75757576','李霞',23,'女','10908753324','441112414242114626','广东省珠海市财富世家',4888,'操作员','在岗')
insert into Employee values('jajxnzzmxn','98989898','王霞',22,'女','14324254565','449556356543456756','广东省珠海市财富世家',4588,'服务员','在岗')
insert into Employee values('pqoaiwjmxb','00000009','陈晓洁',23,'女','13124141098','440009770987656536','广东省珠海市财富世家',4588,'服务员','在岗')
insert into Employee values('lkdkjxnbzm','01313409','李六环',23,'女','12233533538','440009098747282117','广东省珠海市财富世家',4588,'服务员','在岗')
insert into Employee values('mncbzcbvzn','00222209','王星',23,'女','11125678898','440009772663888889','广东省珠海市财富世家',4588,'服务员','在岗')
insert into Employee values('pzemzienqy','75300009','赵美迪',24,'女','10008764670','447776361837181193','广东省珠海市财富世家',4588,'服务员','在岗')
insert into Employee values('truxurnxia','08443631','刘洁',23,'女','10092847261','447758282849210536','广东省珠海市财富世家',4588,'服务员','在岗')
insert into Employee values('lznjhjsuwu','11111111','李杰',25,'男','13185772629','440906472612738389','广东省珠海市财富世家',5888,'经理','在岗')
insert into Employee values('zqiwisnawa','12909753','王斌',25,'女','12139483389','448837173774626362','广东省珠海市财富世家',5888,'经理','在岗')


--查询
select COUNT(EmTion) from Employee 


--创建桌号/包间表
create table Ramadhins
(
	Rid int primary key identity(1,1) ,								--号码id
	Radhin varchar(10),									--桌号/包间号  001...050..100 / A001...A50
	Rtate varchar(5),									--状态	
)
select * from Ramadhins
update Ramadhins set  Radhin = '009' where Radhin = '09'
insert into Ramadhins values('A01','空')
insert into Ramadhins values('A02','空')
insert into Ramadhins values('A03','空')
insert into Ramadhins values('A04','空')
insert into Ramadhins values('A05','空')
insert into Ramadhins values('A06','空')
insert into Ramadhins values('A07','空')
insert into Ramadhins values('A08','空')
insert into Ramadhins values('A09','空')
insert into Ramadhins values('A10','空')
insert into Ramadhins values('A11','空')
insert into Ramadhins values('A12','空')
insert into Ramadhins values('A13','空')
insert into Ramadhins values('A14','空')
insert into Ramadhins values('A15','空')
insert into Ramadhins values('A16','空')
insert into Ramadhins values('A17','空')
insert into Ramadhins values('A18','空')
insert into Ramadhins values('A19','空')
insert into Ramadhins values('A20','空')
insert into Ramadhins values('A21','空')
insert into Ramadhins values('A22','空')

insert into Ramadhins values('清香亭','空')
insert into Ramadhins values('明月亭','空')
insert into Ramadhins values('秋水亭','空')
insert into Ramadhins values('露华亭','空')
insert into Ramadhins values('春风亭','空')
insert into Ramadhins values('夏雨亭','空')
insert into Ramadhins values('凤吟亭','空')
insert into Ramadhins values('览翠亭','空')
insert into Ramadhins values('紫霞亭','空')
insert into Ramadhins values('玲珑亭','空')
insert into Ramadhins values('华锦亭','空')

select * from Ramadhins

DROP TABLE Ramadhins

--创建会员表
create table Menber
(
	MenberId int primary key identity(1,1),											--会员id
	MeMember int check(MeMember>=3 and MeMember<=0),					--会员等级
	Meintegral int not null,											--会员积分
)
insert into Menber values(3,550)
insert into Menber values(2,300)
insert into Menber values(1,150)





--创建供应商表
create table supplier
(
	[Sid] int primary key identity(101,1),					--供应商id
	Sname varchar(100) not null,							--供应商名称
	Sphone varchar(15) not null,							--供应商电话
	Saddress varchar(100) not null,							--供应商地址

)
insert into supplier values('珠海市杰民农副产品有限公司','15412439188',' 广东省珠海市香洲区华威路65号前山商贸物流中心3435号')
insert into supplier values('珠海市得一有限公司','0756-2293841','珠海市香洲柠溪路柠发商贸城首层')
insert into supplier values('中山海鲜濠水产有限公司','18676186325','中山市沙溪镇厚山自然下街四巷1号1楼1卡')
insert into supplier values('珠海市源兴卫农产品有限公司','121443675321','珠海市香洲区明华一路5号2栋一楼综合功能区第A16号')
insert into supplier values('珠海市海源盛蔬菜果品有限公司','13332261888','珠海市香洲区明华一路5号2栋配送物流园一楼第37号')
insert into supplier values('贵州茅台专卖店','(0756)8883169','广东省珠海市香洲区情侣南路288号一层113号之三商铺')
insert into supplier values('五粮液(红山路店)','(0756)2618466','珠海市香洲区红山路金桦城市花园')


select * from supplier

--创建商品表
create table Goods
(
	Gid int primary key identity(1001,1),											--商品id
	Gname varchar(20) not null,										--商品名称
	Gprice money not null,											--商品价格
	Gtione varchar(5) not null,										--商品规格
	[Sid] int foreign key ([Sid]) references supplier([Sid]) not null,	--供货商id
	Gnumber int not null,											--商品数量
	
)
insert into supplier values('五粮春',288,'250ml','五粮液(红山路店)',20)
insert into supplier values('茅台',3888,'375ml','贵州茅台专卖店',15)
insert into supplier values('剑南春',488,'500ml','五粮液(红山路店)',15)
insert into supplier values('汾酒',388,'375ml','五粮液(红山路店)',20)
insert into supplier values('国窖',888,'500ml','贵州茅台专卖店',15)
insert into supplier values('古井贡酒',688,'500ml','贵州茅台专卖店',10)
insert into supplier values('长乐烧',288,'500ml','五粮液(红山路店)',10)



select  * from Menu where  FypeId = 3


--创建单号表
create table Number 
(
	Nid int primary key identity(1,1 ),		--单号id    
	BiNumber varchar(50) unique ,			--单号
	Radhin varchar(20)not null,				--桌号
	Nstate int default'0' not null,			--状态	
)

update Number  set BiNumber='No.000001',Radhin=1,Nstate=4 where Nid = 1
insert into Number values('No.000018','A17',0)

select top 100*from Number 
drop table Number
	drop table Bill
	
	select top 100 * from Number where Nstate='5'and Radhin=0
--创建账单表
create table Bill
(
	Bid int identity(1,1),												--账单id
	Nid int foreign key (Nid) references Number(Nid) not null,			--账单编号
	Radhin varchar(20) null ,											--桌号id
	MeName varchar(20) not null,										--菜品
	MeNumber int not null,												--菜品数量
	Btaste varchar(50),													--口味
	Bnote  varchar(1000),												--备注
	BiPrice money not null,												--总金额
	Btime  Datetime not null,											--下单日期
)
SELECT * FROM Number
select top 100 *from Bill A,Number B where A.Nid = B.Nid 
insert	into Bill values(3,1,2,'fafds','312',256,'2020-1-1')
******
insert	into Bill values(4,1,2,256,'4132','32141',123,'2020-1-1'),(7,1,1,128,'4321','14312',123,'2020-1-1')

update Bill set Bid=2,'A02','白米饭',2,'微辣',1,7,'2002-6-18' where Bid ='2'

select top 100 * from Bill where Radhin='014'

select top 100 * from Bill A,Number B where A.Nid = B.Nid and A.MeName = '白米饭' and B.Radhin = 'A02'
*

drop table Bill

delete from Bill where Radhin = '014' and BiPrice = '110'

--考勤id，考勤时间，员工id，

--创建考勤表
create table Rcheck
(
	Rid int identity(1,1),
	Rdate datetime not null,
	EmId int foreign key (EmId) references Employee(EmId)not null,	--员工id
)


--修改账单，存储过程
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

exec UpdateBillInfo 1,2,'A02','小米',2,'特辣',1,8,'2002-6-18'

select * from Bill