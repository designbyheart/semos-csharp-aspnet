CREATE DATABASE MyDB;
GO

USE MyDB;
GO

CREATE TABLE [Member] (
    [Name] 		nvarchar(64) NOT NULL,
    [Password] 	nvarchar(64) NOT NULL,
    [EMail] 	nvarchar(255) NULL,
    PRIMARY KEY (Name)
);
GO

Insert Into Member Values('abu','abu123',NULL);
Insert Into Member Values('ali','ali123','');

SELECT * FROM Member;
GO

CREATE TABLE [Country] (
    [Code] 	char(2) NOT NULL,
    [Name] 	varchar(128) NOT NULL,
    PRIMARY KEY (Code)
);
GO

Insert Into Country Values('cn','China');
Insert Into Country Values('jp','Japan');
Insert Into Country Values('kr','South Korea');
Insert Into Country Values('my','Malaysia');
Insert Into Country Values('om','Oman');
Insert Into Country Values('sa','Saudi Arabia');
Insert Into Country Values('sg','Singapore');

SELECT * FROM Country;
GO

CREATE TABLE [State] (
    [ID] 	int NOT NULL IDENTITY,
    [Country] 	char(2) NOT NULL,
    [Name] 	varchar(128),
    [LocalName] nvarchar(128),
    PRIMARY KEY (ID)
);
GO

Insert Into State (Country,Name,LocalName) Values('my','Selangor',	     'Selangor');
Insert Into State (Country,Name,LocalName) Values('my','Pahang',	     'Pahang');
Insert Into State (Country,Name,LocalName) Values('my','Sabah',		     'Sabah');
Insert Into State (Country,Name,LocalName) Values('my','Sarawak',	     'Sarawak');
Insert Into State (Country,Name,LocalName) Values('my','Perlis',	     'Perlis');
Insert Into State (Country,Name,LocalName) Values('my','Kedah',		     'Kedah');
Insert Into State (Country,Name,LocalName) Values('my','Negeri Sembilan',    'Negeri Sembilan');
Insert Into State (Country,Name,LocalName) Values('my','Johor',		     'Johor');
Insert Into State (Country,Name,LocalName) Values('my','Penang',	     'Pulau Pinang');
Insert Into State (Country,Name,LocalName) Values('my','Terengganu',	     'Terengganu');
Insert Into State (Country,Name,LocalName) Values('my','Kelantan',	     'Kelantan');
Insert Into State (Country,Name,LocalName) Values('my','Perak',		     'Perak');
Insert Into State (Country,Name,LocalName) Values('my','Malacca',	     'Melaka');
Insert Into State (Country,Name,LocalName) Values('my','Federal Territories','Wilayah Persekutuan');

Insert Into State (Country,Name,LocalName) Values('cn','Andong',	N'安东');
Insert Into State (Country,Name,LocalName) Values('cn','Anhui',		N'安徽');
Insert Into State (Country,Name,LocalName) Values('cn','Chahar',	N'察哈尔');
Insert Into State (Country,Name,LocalName) Values('cn','Fujian',	N'福建');
Insert Into State (Country,Name,LocalName) Values('cn','Gansu',		N'甘肃');
Insert Into State (Country,Name,LocalName) Values('cn','Guangdong',	N'广东');
Insert Into State (Country,Name,LocalName) Values('cn','Guangxi',	N'广西');
Insert Into State (Country,Name,LocalName) Values('cn','Guizhou',	N'贵州');
Insert Into State (Country,Name,LocalName) Values('cn','Hainan',	N'海南');
Insert Into State (Country,Name,LocalName) Values('cn','Hebei',		N'河北');
Insert Into State (Country,Name,LocalName) Values('cn','Hejiang',	N'合江');
Insert Into State (Country,Name,LocalName) Values('cn','Heilongjiang',	N'黑龙江');
Insert Into State (Country,Name,LocalName) Values('cn','Henan',		N'河南');
Insert Into State (Country,Name,LocalName) Values('cn','Hubei',		N'湖北');
Insert Into State (Country,Name,LocalName) Values('cn','Hunan',		N'湖南');
Insert Into State (Country,Name,LocalName) Values('cn','Jiangsu',	N'江苏');
Insert Into State (Country,Name,LocalName) Values('cn','Jiangxi',	N'江西');
Insert Into State (Country,Name,LocalName) Values('cn','Jilin',		N'吉林');
Insert Into State (Country,Name,LocalName) Values('cn','Liaobei',	N'辽北');
Insert Into State (Country,Name,LocalName) Values('cn','Liaodong',	N'辽东');
Insert Into State (Country,Name,LocalName) Values('cn','Liaoning',	N'辽宁');
Insert Into State (Country,Name,LocalName) Values('cn','Liaoxi',	N'辽西');
Insert Into State (Country,Name,LocalName) Values('cn','Nenjiang',	N'嫩江');
Insert Into State (Country,Name,LocalName) Values('cn','Ningxia',	N'宁夏');
Insert Into State (Country,Name,LocalName) Values('cn','Mudanjiang',	N'牡丹江');
Insert Into State (Country,Name,LocalName) Values('cn','Pingyuan',	N'平原');
Insert Into State (Country,Name,LocalName) Values('cn','Qinghai',	N'青海');
Insert Into State (Country,Name,LocalName) Values('cn','Rehe',		N'热河');
Insert Into State (Country,Name,LocalName) Values('cn','Sichuan',	N'四川');
Insert Into State (Country,Name,LocalName) Values('cn','Shaanxi',	N'陕西');
Insert Into State (Country,Name,LocalName) Values('cn','Shandong',	N'山东');
Insert Into State (Country,Name,LocalName) Values('cn','Shanxi',	N'山西');
Insert Into State (Country,Name,LocalName) Values('cn','Songjiang',	N'松江');
Insert Into State (Country,Name,LocalName) Values('cn','Suiyuan',	N'绥远');
Insert Into State (Country,Name,LocalName) Values('cn','Taiwan',	N'台湾');
Insert Into State (Country,Name,LocalName) Values('cn','Xikang',	N'西康');
Insert Into State (Country,Name,LocalName) Values('cn','Xing''an',	N'兴安');
Insert Into State (Country,Name,LocalName) Values('cn','Xinjiang',	N'新疆');
Insert Into State (Country,Name,LocalName) Values('cn','Yunnan',	N'云南');
Insert Into State (Country,Name,LocalName) Values('cn','Zhejiang',	N'浙江');
Insert Into State (Country,Name,LocalName) Values('cn','Guangxi',	N'广西');
Insert Into State (Country,Name,LocalName) Values('cn','Inner Mongolia',N'內蒙古');
Insert Into State (Country,Name,LocalName) Values('cn','Ningxia',	N'宁夏');
Insert Into State (Country,Name,LocalName) Values('cn','Tibet',		N'西藏');

Insert Into State (Country,Name,LocalName) Values('sg','Central Region',   'Central Region');
Insert Into State (Country,Name,LocalName) Values('sg','East Region',	   'East Region');
Insert Into State (Country,Name,LocalName) Values('sg','North Region',	   'North Region');
Insert Into State (Country,Name,LocalName) Values('sg','North-East Region','North-East Region');
Insert Into State (Country,Name,LocalName) Values('sg','West Region',	   'West Region');

Insert Into State (Country,Name,LocalName) Values('kr','Busan',		   N'부산시');
Insert Into State (Country,Name,LocalName) Values('kr','North Chungcheong',N'충청북도');
Insert Into State (Country,Name,LocalName) Values('kr','South Chungcheong',N'충청남도');
Insert Into State (Country,Name,LocalName) Values('kr','Daegu',		   N'대구시');
Insert Into State (Country,Name,LocalName) Values('kr','Daejeon',	   N'대전시');
Insert Into State (Country,Name,LocalName) Values('kr','Gangwon',	   N'강원도');
Insert Into State (Country,Name,LocalName) Values('kr','Gwangju',	   N'광주시');
Insert Into State (Country,Name,LocalName) Values('kr','Gyeonggi',	   N'경기도');
Insert Into State (Country,Name,LocalName) Values('kr','North Gyeongsang', N'경상북도');
Insert Into State (Country,Name,LocalName) Values('kr','South Gyeongsang', N'경상남도');
Insert Into State (Country,Name,LocalName) Values('kr','North Hamgyeong',  N'함경북도');
Insert Into State (Country,Name,LocalName) Values('kr','South Hamgyeong',  N'함경남도');
Insert Into State (Country,Name,LocalName) Values('kr','North Hwanghae',   N'황해북도');
Insert Into State (Country,Name,LocalName) Values('kr','South Hwanghae',   N'황해남도');
Insert Into State (Country,Name,LocalName) Values('kr','Incheon',	   N'인천시');
Insert Into State (Country,Name,LocalName) Values('kr','Jagang',	   N'자강도');
Insert Into State (Country,Name,LocalName) Values('kr','Jeju',		   N'제주도');
Insert Into State (Country,Name,LocalName) Values('kr','North Jeolla',	   N'전라북도');
Insert Into State (Country,Name,LocalName) Values('kr','South Jeolla',	   N'전라남도');
Insert Into State (Country,Name,LocalName) Values('kr','Nampo',		   N'남포시');
Insert Into State (Country,Name,LocalName) Values('kr','Naseon',	   N'나선시/라선시');
Insert Into State (Country,Name,LocalName) Values('kr','North Pyeongan',   N'평안북도');
Insert Into State (Country,Name,LocalName) Values('kr','South Pyeongan',   N'평안남도');
Insert Into State (Country,Name,LocalName) Values('kr','Pyeongyang',	   N'평양시');
Insert Into State (Country,Name,LocalName) Values('kr','Yanggang',	   N'양강도/량강도');
Insert Into State (Country,Name,LocalName) Values('kr','Sejong',	   N'세종시');
Insert Into State (Country,Name,LocalName) Values('kr','Seoul',		   N'서울시');
Insert Into State (Country,Name,LocalName) Values('kr','Ulsan',		   N'울산시');

Insert Into State (Country,Name,LocalName) Values('sa','''Asir',	  N'عسير');
Insert Into State (Country,Name,LocalName) Values('sa','Bahah',		  N'الباحة');
Insert Into State (Country,Name,LocalName) Values('sa','Eastern Province',N'الشرقية');
Insert Into State (Country,Name,LocalName) Values('sa','Ha''il',	  N'حائل');
Insert Into State (Country,Name,LocalName) Values('sa','Jawf',		  N'الجوف');
Insert Into State (Country,Name,LocalName) Values('sa','Jizan',		  N'جيزان');
Insert Into State (Country,Name,LocalName) Values('sa','Al Madinah',	  N'المدينة');
Insert Into State (Country,Name,LocalName) Values('sa','Makkah',	  N'مكة');
Insert Into State (Country,Name,LocalName) Values('sa','Najran',	  N'نجران');
Insert Into State (Country,Name,LocalName) Values('sa','Northern Borders',N'الحدودالشمالية');
Insert Into State (Country,Name,LocalName) Values('sa','Qassim',	  N'القصيم');
Insert Into State (Country,Name,LocalName) Values('sa','Riyadh',	  N'الرياض');
Insert Into State (Country,Name,LocalName) Values('sa','Tabuk',		  N'تبوك');

Insert Into State (Country,Name,LocalName) Values('jp','Aichi',	   N'愛知県');
Insert Into State (Country,Name,LocalName) Values('jp','Akita',	   N'秋田県');
Insert Into State (Country,Name,LocalName) Values('jp','Aomori',   N'青森県');
Insert Into State (Country,Name,LocalName) Values('jp','Chiba',	   N'千葉県');
Insert Into State (Country,Name,LocalName) Values('jp','Ehime',	   N'愛媛県');
Insert Into State (Country,Name,LocalName) Values('jp','Fukui',	   N'福井県');
Insert Into State (Country,Name,LocalName) Values('jp','Fukuoka',  N'福岡県');
Insert Into State (Country,Name,LocalName) Values('jp','Fukushima',N'福島県');
Insert Into State (Country,Name,LocalName) Values('jp','Gifu',	   N'岐阜県');
Insert Into State (Country,Name,LocalName) Values('jp','Gunma',	   N'群馬県');
Insert Into State (Country,Name,LocalName) Values('jp','Hiroshima',N'広島県');
Insert Into State (Country,Name,LocalName) Values('jp','Hokkaido', N'北海道');
Insert Into State (Country,Name,LocalName) Values('jp','Hyōgo',	   N'兵庫県');
Insert Into State (Country,Name,LocalName) Values('jp','Ibaraki',  N'茨城県');
Insert Into State (Country,Name,LocalName) Values('jp','Ishikawa', N'石川県');
Insert Into State (Country,Name,LocalName) Values('jp','Iwate',	   N'岩手県');
Insert Into State (Country,Name,LocalName) Values('jp','Kagawa',   N'香川県');
Insert Into State (Country,Name,LocalName) Values('jp','Kagoshima',N'鹿児島県');
Insert Into State (Country,Name,LocalName) Values('jp','Kanagawa', N'神奈川県');
Insert Into State (Country,Name,LocalName) Values('jp','Kōchi',	   N'高知県');
Insert Into State (Country,Name,LocalName) Values('jp','Kumamoto', N'熊本県');
Insert Into State (Country,Name,LocalName) Values('jp','Kyoto',	   N'京都府');
Insert Into State (Country,Name,LocalName) Values('jp','Mie',	   N'三重県');
Insert Into State (Country,Name,LocalName) Values('jp','Miyagi',   N'宮城県');
Insert Into State (Country,Name,LocalName) Values('jp','Miyazaki', N'宮崎県');
Insert Into State (Country,Name,LocalName) Values('jp','Nagano',   N'長野県');
Insert Into State (Country,Name,LocalName) Values('jp','Nagasaki', N'長崎県');
Insert Into State (Country,Name,LocalName) Values('jp','Nara',	   N'奈良県');
Insert Into State (Country,Name,LocalName) Values('jp','Niigata',  N'新潟県');
Insert Into State (Country,Name,LocalName) Values('jp','Ōita',	   N'大分県');
Insert Into State (Country,Name,LocalName) Values('jp','Okayama',  N'岡山県');
Insert Into State (Country,Name,LocalName) Values('jp','Okinawa',  N'沖縄県');
Insert Into State (Country,Name,LocalName) Values('jp','Osaka',	   N'大阪府');
Insert Into State (Country,Name,LocalName) Values('jp','Saga',	   N'佐賀県');
Insert Into State (Country,Name,LocalName) Values('jp','Saitama',  N'埼玉県');
Insert Into State (Country,Name,LocalName) Values('jp','Shiga',	   N'滋賀県');
Insert Into State (Country,Name,LocalName) Values('jp','Shimane',  N'島根県');
Insert Into State (Country,Name,LocalName) Values('jp','Shizuoka', N'静岡県');
Insert Into State (Country,Name,LocalName) Values('jp','Tochigi',  N'栃木県');
Insert Into State (Country,Name,LocalName) Values('jp','Tokushima',N'徳島県');
Insert Into State (Country,Name,LocalName) Values('jp','Tokyo',	   N'東京都');
Insert Into State (Country,Name,LocalName) Values('jp','Tottori',  N'鳥取県');
Insert Into State (Country,Name,LocalName) Values('jp','Toyama',   N'富山県');
Insert Into State (Country,Name,LocalName) Values('jp','Wakayama', N'和歌山県');
Insert Into State (Country,Name,LocalName) Values('jp','Yamagata', N'山形県');
Insert Into State (Country,Name,LocalName) Values('jp','Yamaguchi',N'山口県');
Insert Into State (Country,Name,LocalName) Values('jp','Yamanashi',N'山梨県');
	
SELECT * FROM State;

GO

