CREATE DATABASE MY_CSHARP_APP;
USE [MY_CSHARP_APP];

GO

CREATE TABLE users (
	_id int NOT NULL IDENTITY(1, 1),
	username nvarchar(64) NOT NULL,
	email nvarchar(128) NOT NULL,
	[password] nvarchar(512) NOT NULL,
	firstname nvarchar(64) NOT NULL,
	lastname nvarchar(64) NOT NULL,
	verified bit NOT NULL DEFAULT 0,
	genre char(1) NOT NULL,
	age int NOT NULL DEFAULT 0,
	_locked bit NOT NULL DEFAULT 0,
	_createdAt datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
	_updatedAt datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
	CONSTRAINT PK_USERS PRIMARY KEY CLUSTERED (_id ASC) WITH (
		PAD_INDEX = OFF,
		STATISTICS_NORECOMPUTE = OFF,
		IGNORE_DUP_KEY = OFF,
		ALLOW_ROW_LOCKS = ON,
		ALLOW_PAGE_LOCKS = ON,
		OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF
	) ON [PRIMARY]
) ON [PRIMARY];

INSERT INTO users (username, email, password, firstname, lastname, _createdAt, _updatedAt)
  VALUES
    ('adreye0', 'adreye0@independent.co.uk', 'feMyfHmdiR', 'Antonetta', 'Dreye', '2022-12-10', '2022-10-25'),
    ('dbrownscombe1', 'dbrownscombe1@yale.edu', 'NR53RA', 'Davine', 'Brownscombe', '2022-05-15', '2022-09-17'),
    ('brustan2', 'brustan2@trellian.com', 'Js1ilvqB1NOK', 'Bail', 'Rustan', '2023-01-31', '2022-12-13'),
    ('dmcwhinnie3', 'dmcwhinnie3@weather.com', 'Uxp3qxbnbtKr', 'Daryle', 'McWhinnie', '2022-04-05', '2022-11-23'),
    ('vpretti4', 'vpretti4@yelp.com', 'rkyiOqcPx', 'Vivienne', 'Pretti', '2022-04-26', '2022-02-12'),
    ('gwaryk5', 'gwaryk5@deliciousdays.com', 'JpGlFT44', 'Gweneth', 'Waryk', '2023-02-10', '2022-07-26'),
    ('xhaysham6', 'xhaysham6@cdc.gov', '4GUdKCIMde', 'Xenia', 'Haysham', '2022-12-20', '2023-01-06'),
    ('sfrail7', 'sfrail7@51.la', 'BZpfvlLCr', 'Storm', 'Frail', '2022-10-15', '2023-01-21'),
    ('tpalin8', 'tpalin8@tripod.com', 'RysKEhvXmF', 'Tomas', 'Palin', '2022-12-17', '2022-05-18'),
    ('rdenholm9', 'rdenholm9@ow.ly', 'iC95Rtp', 'Rebeca', 'Denholm', '2022-03-07', '2022-08-03'),
    ('vshaxbya', 'vshaxbya@statcounter.com', 'tt5V46Y', 'Vania', 'Shaxby', '2022-03-21', '2022-11-22'),
    ('larranb', 'larranb@naver.com', 'oVJNwVrl', 'Lodovico', 'Arran', '2022-06-18', '2022-12-11'),
    ('cfrancesc', 'cfrancesc@ning.com', 'UpTVbY9lSgj', 'Chrissy', 'Frances', '2022-12-11', '2022-09-03'),
    ('spaprotnyd', 'spaprotnyd@trellian.com', 'Ol774cmpOkd', 'Samson', 'Paprotny', '2022-11-16', '2022-03-14'),
    ('mfouche', 'mfouche@amazon.de', 'Nps1pmal', 'Michell', 'Fouch', '2023-01-01', '2022-05-08'),
    ('rnolif', 'rnolif@nba.com', 'fJ8IUj5', 'Rici', 'Noli', '2022-05-05', '2022-03-07'),
    ('gbeausangg', 'gbeausangg@pbs.org', 'wiLgGoDj', 'Glen', 'Beausang', '2022-08-28', '2023-01-08'),
    ('pcolloffh', 'pcolloffh@aol.com', 'GrUmCN', 'Patrica', 'Colloff', '2022-05-26', '2022-07-30'),
    ('lbretoni', 'lbretoni@taobao.com', 'hF9dWGBd1', 'Lurette', 'Breton', '2023-01-10', '2022-10-25'),
    ('mmoroj', 'mmoroj@about.me', '9HG6FLV3C', 'Mellicent', 'Moro', '2022-06-20', '2022-12-27'),
    ('bvigarsk', 'bvigarsk@abc.net.au', 'Jwr1InjQxPUt', 'Bradford', 'Vigars', '2022-04-10', '2022-10-23'),
    ('cingerfieldl', 'cingerfieldl@friendfeed.com', 'ZC6YcR', 'Charmaine', 'Ingerfield', '2022-06-08', '2022-12-06'),
    ('dwindressm', 'dwindressm@woothemes.com', 'OsE37MAp', 'Donnell', 'Windress', '2022-08-27', '2022-02-13'),
    ('acornsn', 'acornsn@illinois.edu', 'XVvhui', 'Antoinette', 'Corns', '2022-09-26', '2022-06-09'),
    ('elowranceo', 'elowranceo@behance.net', 'GK9vURwbDc', 'Eldredge', 'Lowrance', '2022-03-13', '2022-11-26'),
    ('fsalmondp', 'fsalmondp@unicef.org', '16r3PZBYPX3', 'Field', 'Salmond', '2023-02-06', '2022-08-10'),
    ('kburtenshawq', 'kburtenshawq@eepurl.com', 'Fmr5kyPWJb', 'Kimball', 'Burtenshaw', '2022-12-20', '2022-10-29'),
    ('cfyrthr', 'cfyrthr@china.com.cn', 'ebws7oGQ', 'Clemmie', 'Fyrth', '2022-12-10', '2023-02-07'),
    ('abedbroughs', 'abedbroughs@reverbnation.com', 'BhQ00zZwTS', 'Anny', 'Bedbrough', '2023-02-10', '2022-10-09'),
    ('ncornbellt', 'ncornbellt@fda.gov', 'nZ0MPlKzK', 'Nealon', 'Cornbell', '2022-11-15', '2022-08-08'),
    ('handryushinu', 'handryushinu@ning.com', 'A4xJ4oM4pP', 'Hillier', 'Andryushin', '2022-08-26', '2022-06-19'),
    ('dhuetsonv', 'dhuetsonv@w3.org', 'pG9WvDIJQi', 'Diarmid', 'Huetson', '2022-11-16', '2022-03-10'),
    ('conowlanw', 'conowlanw@acquirethisname.com', 'yo0L4z6', 'Chadwick', 'O''Nowlan', '2022-03-28', '2022-03-11'),
    ('bhabornx', 'bhabornx@usnews.com', 'rtabeSuEAKCW', 'Brooke', 'Haborn', '2022-02-12', '2022-06-14'),
    ('svannikovy', 'svannikovy@ebay.com', 'PBEkIz5g', 'Sutherland', 'Vannikov', '2022-06-21', '2022-10-21'),
    ('mgoodsellz', 'mgoodsellz@discovery.com', 'yvW8EG', 'Marlena', 'Goodsell', '2022-08-17', '2022-09-17'),
    ('ndeely10', 'ndeely10@dagondesign.com', 'kb5Dna1moqs', 'Nickey', 'Deely', '2022-08-06', '2022-02-18'),
    ('mparminter11', 'mparminter11@edublogs.org', '3fBIEtyI4', 'Morly', 'Parminter', '2022-05-12', '2022-09-05'),
    ('lplail12', 'lplail12@uol.com.br', 'OeH4top', 'Loydie', 'Plail', '2022-07-31', '2022-07-12'),
    ('wbush13', 'wbush13@printfriendly.com', 'yCEmurCG6', 'Wilton', 'Bush', '2022-12-10', '2023-01-30'),
    ('bearengey14', 'bearengey14@jimdo.com', 'o5w6InH8BE', 'Buddie', 'Earengey', '2022-07-23', '2023-02-06'),
    ('jmccromley15', 'jmccromley15@skyrock.com', 'CaUR2aBCWw5g', 'Jess', 'McCromley', '2023-01-22', '2022-02-25'),
    ('lpittford16', 'lpittford16@dailymotion.com', 'fuMBHQl9zxK', 'Lou', 'Pittford', '2022-06-24', '2022-05-23'),
    ('kblondell17', 'kblondell17@sbwire.com', 'M4AC7S', 'Klement', 'Blondell', '2023-01-20', '2022-10-27'),
    ('cramage18', 'cramage18@virginia.edu', 'LuYTqBuOpf', 'Cleve', 'Ramage', '2022-07-25', '2022-03-30'),
    ('fmoscon19', 'fmoscon19@washingtonpost.com', '7C7DQ19', 'Frannie', 'Moscon', '2022-02-21', '2022-05-09'),
    ('ilowde1a', 'ilowde1a@bloglines.com', 'CruW4bhU9Ty', 'Ivar', 'Lowde', '2023-02-05', '2022-05-09'),
    ('alongworth1b', 'alongworth1b@sogou.com', 'tOLyle12O', 'Andreana', 'Longworth', '2022-07-27', '2022-12-10'),
    ('rhousin1c', 'rhousin1c@scientificamerican.com', 'g8xMrZ', 'Romy', 'Housin', '2022-11-17', '2023-01-04'),
    ('jsaur1d', 'jsaur1d@slate.com', 's5vKaThzMcvE', 'Justin', 'Saur', '2022-07-01', '2022-11-10'),
    ('strevaskiss1e', 'strevaskiss1e@list-manage.com', 'rHL4PRn6xTpO', 'Sileas', 'Trevaskiss', '2022-05-31', '2022-09-22'),
    ('ewidger1f', 'ewidger1f@usa.gov', '4cTrafIzh', 'Eachelle', 'Widger', '2022-12-26', '2022-06-10'),
    ('dhelbeck1g', 'dhelbeck1g@slideshare.net', '77drQ5', 'Damaris', 'Helbeck', '2023-01-31', '2022-07-08'),
    ('lwendover1h', 'lwendover1h@goo.gl', 'uT5asfsZqdIY', 'Laural', 'Wendover', '2022-04-12', '2022-11-05'),
    ('drossin1i', 'drossin1i@wufoo.com', 'bcJcdZIUhbA', 'Dom', 'Rossin', '2022-11-24', '2022-07-22'),
    ('scockshoot1j', 'scockshoot1j@ifeng.com', 'tz3PWviBUsi', 'Stephannie', 'Cockshoot', '2023-02-01', '2022-10-16'),
    ('asiegertsz1k', 'asiegertsz1k@nsw.gov.au', 'MyPSYWgMGQR', 'Antonina', 'Siegertsz', '2022-04-02', '2022-04-28'),
    ('flambswood1l', 'flambswood1l@newyorker.com', 'JgGph9TueJm', 'Florinda', 'Lambswood', '2022-12-22', '2022-08-25'),
    ('cbettis1m', 'cbettis1m@imdb.com', 'MMAqTeZx', 'Chantal', 'Bettis', '2022-04-25', '2022-08-06'),
    ('aleader1n', 'aleader1n@nih.gov', 'zcG6bwyI', 'Alfie', 'Leader', '2023-01-12', '2022-04-29'),
    ('ehesse1o', 'ehesse1o@wsj.com', 'sqKiuZto68', 'Emilia', 'Hesse', '2022-06-25', '2022-04-14'),
    ('mchapple1p', 'mchapple1p@spiegel.de', 'NRbI54E04av', 'Minny', 'Chapple', '2022-02-28', '2022-06-03'),
    ('pcaven1q', 'pcaven1q@eventbrite.com', '92TOArD3', 'Pauly', 'Caven', '2022-11-08', '2022-05-13'),
    ('fholdworth1r', 'fholdworth1r@baidu.com', 'EbUjbfvCLGl9', 'Frayda', 'Holdworth', '2022-09-21', '2022-11-23'),
    ('lbeckley1s', 'lbeckley1s@tripod.com', 'wRXnRkR', 'Lauree', 'Beckley', '2022-07-04', '2023-02-08'),
    ('kballam1t', 'kballam1t@skyrock.com', 'BcOEdr', 'Kaja', 'Ballam', '2022-09-02', '2022-07-24'),
    ('amacdearmid1u', 'amacdearmid1u@example.com', '7tz9Pi', 'Anabel', 'MacDearmid', '2022-04-17', '2023-01-14'),
    ('mminget1v', 'mminget1v@sfgate.com', 'SdGbR8D', 'Moe', 'Minget', '2022-08-30', '2022-10-17'),
    ('gkail1w', 'gkail1w@tripadvisor.com', 'LFzYgFO2xBN', 'Garwood', 'Kail', '2022-07-19', '2022-04-24'),
    ('hjewett1x', 'hjewett1x@sitemeter.com', 'YvzSOUY0wQtN', 'Henryetta', 'Jewett', '2023-02-08', '2022-05-16'),
    ('dfaccini1y', 'dfaccini1y@yahoo.co.jp', 'W0WEjOOa', 'Davina', 'Faccini', '2022-04-04', '2022-03-27'),
    ('jcapelle1z', 'jcapelle1z@digg.com', 'ggPs5rRqc', 'Jannelle', 'Capelle', '2022-06-25', '2022-09-11'),
    ('yrandleson20', 'yrandleson20@epa.gov', 'yZ1nFOHEfgUg', 'Yoshi', 'Randleson', '2022-08-01', '2022-07-24'),
    ('selstow21', 'selstow21@symantec.com', 'cP9pDvfu', 'Skell', 'Elstow', '2022-12-07', '2022-02-14'),
    ('kdyball22', 'kdyball22@newsvine.com', '28vEjuLWT4P', 'Kinnie', 'Dyball', '2022-08-23', '2023-01-15'),
    ('chember23', 'chember23@xing.com', 'uIxLFj2', 'Clark', 'Hember', '2023-01-19', '2022-03-15'),
    ('calexandersson24', 'calexandersson24@ebay.co.uk', 'Uu9pfeI', 'Crystie', 'Alexandersson', '2022-11-10', '2022-10-24'),
    ('anowell25', 'anowell25@biglobe.ne.jp', 'SKtlzt', 'Aeriel', 'Nowell', '2022-09-17', '2022-10-27'),
    ('pdallow26', 'pdallow26@behance.net', 'cqv5xwddf', 'Poppy', 'Dallow', '2022-02-26', '2023-01-19'),
    ('dodoireidh27', 'dodoireidh27@yale.edu', '5RUnQPUWUcb8', 'Daryn', 'O''Doireidh', '2022-08-30', '2022-03-09'),
    ('rmcnellis28', 'rmcnellis28@comsenz.com', '6MhDhKHUQ', 'Reg', 'McNellis', '2022-06-21', '2022-08-13'),
    ('abeaushaw29', 'abeaushaw29@chicagotribune.com', 'LAqQACLHeST5', 'Ashlee', 'Beaushaw', '2022-07-26', '2022-11-27'),
    ('ksabben2a', 'ksabben2a@dion.ne.jp', 'LuxzRhe', 'Katee', 'Sabben', '2022-12-08', '2023-01-15'),
    ('mhagger2b', 'mhagger2b@clickbank.net', 'rXlA3uR', 'Mordecai', 'Hagger', '2022-05-13', '2022-03-04'),
    ('lwhittlesee2c', 'lwhittlesee2c@github.com', 'kgbmVuxPHv', 'Lay', 'Whittlesee', '2022-05-30', '2022-02-28'),
    ('fbehnen2d', 'fbehnen2d@about.com', 'DgvOEi80', 'Filip', 'Behnen', '2023-01-29', '2022-08-21'),
    ('fbenettelli2e', 'fbenettelli2e@netvibes.com', 'G8iFZGJG', 'Frank', 'Benettelli', '2022-09-24', '2022-10-18'),
    ('jbolzmann2f', 'jbolzmann2f@amazonaws.com', 'XArkZ6FOOE', 'Josi', 'Bolzmann', '2022-09-04', '2022-08-31'),
    ('nskatcher2g', 'nskatcher2g@irs.gov', 'bGcmKX5KcGVv', 'Neda', 'Skatcher', '2022-06-17', '2023-02-06'),
    ('psarvar2h', 'psarvar2h@tripadvisor.com', '4EO5wvSwVOu', 'Pepe', 'Sarvar', '2023-01-19', '2022-07-20'),
    ('gfateley2i', 'gfateley2i@java.com', 'V97iNALOHGBo', 'Garwin', 'Fateley', '2022-02-12', '2022-03-16'),
    ('ledgeson2j', 'ledgeson2j@harvard.edu', 'IaWym6XDZemb', 'Lyndsey', 'Edgeson', '2023-01-11', '2022-06-06'),
    ('akroll2k', 'akroll2k@eepurl.com', '7DuGERmshy', 'Allis', 'Kroll', '2022-06-29', '2022-12-07'),
    ('lcatterick2l', 'lcatterick2l@bizjournals.com', 'ty1XwowifQi4', 'Luigi', 'Catterick', '2022-09-01', '2022-05-28'),
    ('gantonin2m', 'gantonin2m@twitter.com', 't9byyuMnus', 'Gabi', 'Antonin', '2022-11-02', '2022-04-10'),
    ('ncampa2n', 'ncampa2n@paginegialle.it', 'IqPJO6', 'Noami', 'Campa', '2022-12-24', '2022-07-24'),
    ('htredget2o', 'htredget2o@t.co', 'aAu6RBDJm', 'Hedi', 'Tredget', '2022-10-27', '2022-03-01'),
    ('baron2p', 'baron2p@desdev.cn', 'P3u6te8T', 'Bobbee', 'Aron', '2022-09-03', '2022-10-27'),
    ('cstevani2q', 'cstevani2q@trellian.com', 'UIo5d45a', 'Charmaine', 'Stevani', '2022-04-05', '2022-12-20'),
    ('kwitten2r', 'kwitten2r@ovh.net', 'v5z5ja', 'Kathi', 'Witten', '2022-03-09', '2022-05-21'),
    ('lmiddle2s', 'lmiddle2s@bbc.co.uk', 'dEybduI', 'Lesley', 'Middle', '2023-01-26', '2022-02-24'),
    ('mcherryman2t', 'mcherryman2t@time.com', 'Ok7vbOpdTJi', 'Maressa', 'Cherryman', '2022-08-29', '2022-03-27'),
    ('tmerck2u', 'tmerck2u@pbs.org', 'SowcUA', 'Teresa', 'Merck', '2022-07-15', '2022-11-10'),
    ('fkitchingham2v', 'fkitchingham2v@com.com', 'Pe5dq5TlF', 'Finlay', 'Kitchingham', '2022-11-01', '2022-09-26'),
    ('cstandishbrooks2w', 'cstandishbrooks2w@reddit.com', '7n4gsFIDPA0', 'Carolynn', 'Standish-Brooks', '2022-08-27', '2023-01-05'),
    ('peliyahu2x', 'peliyahu2x@columbia.edu', 'bekfAeBsll', 'Pearla', 'Eliyahu', '2022-03-13', '2022-11-21'),
    ('sfrankham2y', 'sfrankham2y@i2i.jp', 'lhWrvHj', 'Sherwood', 'Frankham', '2023-02-08', '2022-06-03'),
    ('kmcginly2z', 'kmcginly2z@miibeian.gov.cn', 'bgXooeAYoU', 'Kizzee', 'McGinly', '2022-05-16', '2022-11-10'),
    ('mkamen30', 'mkamen30@google.ru', 'TbuKIAz6', 'Mariele', 'Kamen', '2022-08-27', '2023-01-22'),
    ('kmckevany31', 'kmckevany31@yale.edu', 'Zkkd0e', 'Karim', 'McKevany', '2022-07-19', '2022-04-23'),
    ('csink32', 'csink32@odnoklassniki.ru', '1eumefdZC', 'Caryl', 'Sink', '2022-12-07', '2022-02-25'),
    ('phelleckas33', 'phelleckas33@buzzfeed.com', 'EpUipNW2T', 'Peyter', 'Helleckas', '2022-05-25', '2022-07-14'),
    ('tfawdry34', 'tfawdry34@telegraph.co.uk', 'hRmCHdcl6M2', 'Tallie', 'Fawdry', '2022-07-15', '2022-06-13'),
    ('jmurley35', 'jmurley35@cnet.com', 'sXSMc79HRes', 'Johan', 'Murley', '2022-11-07', '2022-03-20'),
    ('vjados36', 'vjados36@webmd.com', 'WrLP8i', 'Valencia', 'Jados', '2022-10-23', '2023-01-27'),
    ('jblinerman37', 'jblinerman37@utexas.edu', 'TK8WY8p', 'Joel', 'Blinerman', '2022-03-29', '2022-02-21'),
    ('lgubbin38', 'lgubbin38@apple.com', 'GqTdXsuWypR', 'Lindi', 'Gubbin', '2022-07-23', '2022-11-19'),
    ('rmackenny39', 'rmackenny39@soundcloud.com', 'Jjff0Ap1yV', 'Riki', 'MacKenny', '2022-05-25', '2022-03-06'),
    ('amomford3a', 'amomford3a@intel.com', 'kmisvkwHkF', 'Alisa', 'Momford', '2022-10-05', '2022-12-19'),
    ('eraddenbury3b', 'eraddenbury3b@bloglines.com', 'fMz0avyaus', 'Evyn', 'Raddenbury', '2022-04-26', '2022-06-23'),
    ('jhanigan3c', 'jhanigan3c@scribd.com', 'MHZjXv', 'Josefina', 'Hanigan', '2022-10-09', '2022-11-27'),
    ('idargan3d', 'idargan3d@blinklist.com', '1VbC2E1W', 'Iormina', 'Dargan', '2022-12-28', '2022-03-06'),
    ('sowen3e', 'sowen3e@miibeian.gov.cn', 'rQoCD3', 'Sammy', 'Owen', '2022-05-24', '2022-09-12'),
    ('ccater3f', 'ccater3f@businesswire.com', 'Fk0k7xwu8X', 'Cass', 'Cater', '2022-12-28', '2022-03-19'),
    ('bleipelt3g', 'bleipelt3g@github.io', 'V4W3xn', 'Bertha', 'Leipelt', '2022-04-01', '2022-10-01'),
    ('pkoch3h', 'pkoch3h@whitehouse.gov', 'demdBbZ', 'Phyllys', 'Koch', '2022-05-13', '2023-01-19'),
    ('mmerrigan3i', 'mmerrigan3i@ucoz.ru', 'R9WxLS1O', 'Miguelita', 'Merrigan', '2022-03-23', '2022-12-01'),
    ('akolczynski3j', 'akolczynski3j@oaic.gov.au', 'eHmFp869EN3', 'Anderson', 'Kolczynski', '2022-12-29', '2022-07-15'),
    ('cbranthwaite3k', 'cbranthwaite3k@woothemes.com', 'pXYGMn', 'Cymbre', 'Branthwaite', '2022-07-16', '2023-01-19'),
    ('acerith3l', 'acerith3l@wikimedia.org', 'gvigAs0Gpj', 'Adolphus', 'Cerith', '2022-04-12', '2023-01-03'),
    ('scollete3m', 'scollete3m@oracle.com', 'IB6ykyWvT3dm', 'Saunders', 'Collete', '2022-12-21', '2022-03-29'),
    ('imolesworth3n', 'imolesworth3n@loc.gov', 'yazdWweDjaP', 'Ingeberg', 'Molesworth', '2022-08-26', '2022-02-20'),
    ('bcudiff3o', 'bcudiff3o@shareasale.com', 'IOggWVLl', 'Brose', 'Cudiff', '2022-06-10', '2022-04-28'),
    ('lbretherick3p', 'lbretherick3p@aol.com', 'mSPmg4ho', 'Liesa', 'Bretherick', '2022-09-03', '2022-05-14'),
    ('bdrage3q', 'bdrage3q@techcrunch.com', 'xyEW48Oe', 'Birk', 'Drage', '2022-06-02', '2022-03-07'),
    ('lboxer3r', 'lboxer3r@un.org', 'P3j5MX1B', 'Laraine', 'Boxer', '2022-11-23', '2022-09-04'),
    ('ajeffress3s', 'ajeffress3s@hhs.gov', 'LVktksEv3CB1', 'Aurilia', 'Jeffress', '2022-05-27', '2022-05-06'),
    ('amynett3t', 'amynett3t@paypal.com', 'uVPCDJ4vvyW', 'Agata', 'Mynett', '2022-09-29', '2022-12-19'),
    ('calleyne3u', 'calleyne3u@nature.com', 'edORUCXpD', 'Clementine', 'Alleyne', '2022-06-04', '2022-06-22'),
    ('dallum3v', 'dallum3v@networksolutions.com', 'elZuZNBDJuy', 'Dianna', 'Allum', '2022-03-26', '2022-09-02'),
    ('avanhesteren3w', 'avanhesteren3w@cnn.com', 'P4MK3ajaPro', 'Ambrosius', 'Van Hesteren', '2022-12-03', '2022-11-29'),
    ('jwalbrun3x', 'jwalbrun3x@live.com', 'KxJeydcrIO', 'Jsandye', 'Walbrun', '2022-10-25', '2022-03-12'),
    ('mfowler3y', 'mfowler3y@networksolutions.com', 'pxAnM2pK7BCM', 'Matthus', 'Fowler', '2022-09-01', '2023-01-17'),
    ('habramovitch3z', 'habramovitch3z@cloudflare.com', 'TSOuiWAe', 'Hanson', 'Abramovitch', '2022-12-25', '2022-10-14'),
    ('aridd40', 'aridd40@dailymail.co.uk', 'EGeXAAiRG', 'Anallise', 'Ridd', '2022-07-07', '2022-08-19'),
    ('pdougary41', 'pdougary41@wikipedia.org', 'xRwLZl65Ovy3', 'Phillip', 'Dougary', '2022-03-15', '2022-05-07'),
    ('atownrow42', 'atownrow42@mtv.com', 'hk8Dndk', 'Alan', 'Townrow', '2022-05-12', '2022-04-09'),
    ('gsollime43', 'gsollime43@facebook.com', 'Qj0s6vreern9', 'Guntar', 'Sollime', '2022-08-25', '2022-03-20'),
    ('gdishman44', 'gdishman44@wikispaces.com', 'lPKu9QRdBnM', 'Garvin', 'Dishman', '2022-07-16', '2022-03-15'),
    ('lmackowle45', 'lmackowle45@dell.com', 'mFLb4J', 'Lyssa', 'MacKowle', '2022-05-22', '2022-11-06'),
    ('theinl46', 'theinl46@msu.edu', 'f6gKJG', 'Tabby', 'Heinl', '2022-09-25', '2022-12-24'),
    ('bphythien47', 'bphythien47@europa.eu', 'd9wgdmb3Lg', 'Brunhilda', 'Phythien', '2022-08-27', '2022-10-23'),
    ('apauley48', 'apauley48@engadget.com', 'xrhp8NYkEfN', 'Ashla', 'Pauley', '2022-11-09', '2022-07-17'),
    ('bmccrackan49', 'bmccrackan49@wordpress.org', 'bOUf8NfCRjTI', 'Blair', 'McCrackan', '2022-03-28', '2022-07-28'),
    ('hgleave4a', 'hgleave4a@hc360.com', '11sGdqOuu5q', 'Harper', 'Gleave', '2022-04-06', '2022-08-17'),
    ('dgoff4b', 'dgoff4b@ezinearticles.com', 'VpjD9tuc7NPE', 'Doe', 'Goff', '2022-10-07', '2022-09-27'),
    ('rbarneville4c', 'rbarneville4c@independent.co.uk', 'fqQNdA', 'Rinaldo', 'Barneville', '2023-01-18', '2022-07-30'),
    ('ncopello4d', 'ncopello4d@163.com', 'taqHK4iw5b', 'Nanci', 'Copello', '2023-02-10', '2022-02-18'),
    ('ostaniford4e', 'ostaniford4e@deliciousdays.com', 's5IWbwYQNGP', 'Ole', 'Staniford', '2022-11-21', '2022-08-28'),
    ('dbridel4f', 'dbridel4f@globo.com', 'kHaKFWHLb6', 'Dominique', 'Bridel', '2022-03-09', '2022-08-12'),
    ('aferon4g', 'aferon4g@yelp.com', 'jRiVmapOAlh', 'Alfreda', 'Feron', '2022-07-17', '2022-02-13'),
    ('zproom4h', 'zproom4h@sphinn.com', 'hiEsgMrPv92V', 'Zacherie', 'Proom', '2022-09-09', '2022-08-12'),
    ('pgellan4i', 'pgellan4i@timesonline.co.uk', 'tOuDmCv8N9ct', 'Phoebe', 'Gellan', '2022-08-14', '2022-05-26'),
    ('lchezelle4j', 'lchezelle4j@hatena.ne.jp', 'zl1eTZAO', 'Lionel', 'Chezelle', '2022-08-05', '2022-11-17'),
    ('jlotterington4k', 'jlotterington4k@wordpress.com', 'H2wBLTAgf', 'Julia', 'Lotterington', '2022-03-18', '2022-11-28'),
    ('ppottery4l', 'ppottery4l@weather.com', 'c7TdGa', 'Penny', 'Pottery', '2022-12-01', '2022-03-06'),
    ('dvelareal4m', 'dvelareal4m@fema.gov', 'W5YiN4l', 'Delmor', 'Velareal', '2022-10-12', '2023-02-07'),
    ('gstogill4n', 'gstogill4n@tinypic.com', 'rOGFuAX', 'Gary', 'Stogill', '2022-10-04', '2022-12-22'),
    ('hgantz4o', 'hgantz4o@reverbnation.com', 'eX2XVGcL7', 'Hamid', 'Gantz', '2022-05-16', '2022-12-31'),
    ('ukuschke4p', 'ukuschke4p@epa.gov', 'p9bcVo', 'Ursala', 'Kuschke', '2023-01-11', '2022-10-08'),
    ('tcollerd4q', 'tcollerd4q@go.com', 'rgEMiBrfDY', 'Tallia', 'Collerd', '2022-08-07', '2022-07-26'),
    ('cplum4r', 'cplum4r@wufoo.com', 'sGVrdc', 'Chico', 'Plum', '2022-07-08', '2022-03-27'),
    ('dvonbrook4s', 'dvonbrook4s@linkedin.com', 'yaCLFyYHcR', 'Derry', 'Von Brook', '2022-08-26', '2022-03-25'),
    ('pdaviot4t', 'pdaviot4t@artisteer.com', 'CDW2TZSbnL', 'Portie', 'Daviot', '2022-11-08', '2023-02-04'),
    ('rcapstick4u', 'rcapstick4u@amazon.de', 'efEGT2Qkx98y', 'Reg', 'Capstick', '2022-10-16', '2022-11-27'),
    ('gwitterick4v', 'gwitterick4v@dedecms.com', 'hHUbvHm', 'Gregg', 'Witterick', '2022-10-27', '2022-09-09'),
    ('btrayhorn4w', 'btrayhorn4w@gov.uk', 'GUh9a1fN30CL', 'Bibbye', 'Trayhorn', '2022-05-28', '2022-08-25'),
    ('jnowaczyk4x', 'jnowaczyk4x@w3.org', '0YyxcR7b', 'Jehu', 'Nowaczyk', '2022-10-10', '2022-09-25'),
    ('imaclardie4y', 'imaclardie4y@microsoft.com', '761vAqL', 'Idette', 'MacLardie', '2022-07-01', '2022-03-27'),
    ('kvanweedenburg4z', 'kvanweedenburg4z@noaa.gov', '1huJddmU', 'Karita', 'Van Weedenburg', '2022-10-23', '2022-12-03'),
    ('vwiltshier50', 'vwiltshier50@google.pl', '7RMymP8P8', 'Virge', 'Wiltshier', '2022-05-30', '2022-04-08'),
    ('abonefant51', 'abonefant51@reuters.com', 'jKQsdB6x8K5', 'Alyssa', 'Bonefant', '2022-04-28', '2022-07-16'),
    ('pciobutaru52', 'pciobutaru52@quantcast.com', 'L4A7DuMZq', 'Percival', 'Ciobutaru', '2022-03-21', '2022-07-06'),
    ('jmilleton53', 'jmilleton53@berkeley.edu', 'j1aEUU8h', 'Jarrad', 'Milleton', '2022-10-19', '2022-06-17'),
    ('bmaliphant54', 'bmaliphant54@yale.edu', 'TtjfO9', 'Bernadina', 'Maliphant', '2022-05-28', '2022-11-29'),
    ('ctourmell55', 'ctourmell55@disqus.com', 'I5DhFLw', 'Cherey', 'Tourmell', '2022-06-27', '2022-08-07'),
    ('lburchnall56', 'lburchnall56@ning.com', 'tcLza8jyj', 'Linda', 'Burchnall', '2022-11-18', '2022-03-16'),
    ('fpigne57', 'fpigne57@hud.gov', 'a9c4zef', 'Floyd', 'Pigne', '2022-07-16', '2022-07-17'),
    ('mnoorwood58', 'mnoorwood58@ocn.ne.jp', 'tbh4pk8JeV', 'Mela', 'Noorwood', '2022-05-18', '2022-05-23'),
    ('lcorde59', 'lcorde59@unc.edu', 'JUnAdZW9jKYF', 'Leanna', 'Corde', '2022-10-10', '2022-07-10'),
    ('flush5a', 'flush5a@hexun.com', 't26JauzamnMr', 'Fabio', 'Lush', '2022-09-02', '2023-02-01'),
    ('hmacdowal5b', 'hmacdowal5b@merriam-webster.com', 'XMF3EejGYuBY', 'Haskell', 'MacDowal', '2022-08-10', '2022-04-20'),
    ('sfendt5c', 'sfendt5c@yahoo.co.jp', 'flv9zC', 'Shermy', 'Fendt', '2022-03-31', '2022-12-22'),
    ('jsabatini5d', 'jsabatini5d@tuttocitta.it', 'Umd6u1okh08', 'Janka', 'Sabatini', '2022-04-26', '2022-08-06'),
    ('ttrighton5e', 'ttrighton5e@craigslist.org', 'rPpYROo', 'Trstram', 'Trighton', '2022-07-06', '2022-02-20'),
    ('hmacilhagga5f', 'hmacilhagga5f@github.io', 'uITUD7ldMdK', 'Hewet', 'MacIlhagga', '2022-04-07', '2023-01-21'),
    ('tohallagan5g', 'tohallagan5g@intel.com', 'CpLZ34', 'Taylor', 'O''Hallagan', '2023-01-06', '2022-05-14'),
    ('eboice5h', 'eboice5h@bluehost.com', 'l2wJmYwn', 'Elvis', 'Boice', '2022-12-22', '2022-11-09'),
    ('capfelmann5i', 'capfelmann5i@paginegialle.it', 'UbU6cvn', 'Clarine', 'Apfelmann', '2022-05-05', '2022-04-22'),
    ('gswiffin5j', 'gswiffin5j@ask.com', 'fWiYqqUK7n9P', 'Gennie', 'Swiffin', '2022-11-30', '2022-09-20');

GO

CREATE TABLE user_sessions (
  _id bigint NOT NULL IDENTITY(1, 1),
  Token nvarchar(512),
  TokenType nvarchar(16),                 /* One of: 'JWT', [...] */
  TokenDeviceType char(1),                /* One of: 'P' for Phone, 'D' for Desktop, 'B' for browser */
  TokenGeneratedAs char(1),               /* One of: 'C' for Cookie, 'S' for String */
  Duration decimal(19, 6),                /*  */
  Ip nvarchar(16) NOT NULL,
  IpV4 nvarchar(16) NOT NULL,
  IpV6 nvarchar(16) NOT NULL,
  StartedAt datetime NOT NULL,
  ClosedAt datetime NOT NULL,
  CloseType char(1) NOT NULL DEFAULT 'N', /* One of: 'U' [U]ser, 'A' [A]utomatically, 'E' [E]xpired */
  Expired bit NOT NULL DEFAULT 0,
	[user_id] int NOT NULL,
	/* ... , */
  CONSTRAINT FK_USER_SESSIONS FOREIGN KEY ([user_id]) REFERENCES users(_id),
	CONSTRAINT PK_USER_SESSIONS PRIMARY KEY CLUSTERED ([_id] ASC) /* WITH (
		PAD_INDEX = OFF,
		STATISTICS_NORECOMPUTE = OFF,
		IGNORE_DUP_KEY = OFF,
		ALLOW_ROW_LOCKS = ON,
		ALLOW_PAGE_LOCKS = ON,
		OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF
	) ON [PRIMARY] */
) ON [PRIMARY];

GO

CREATE TABLE products (
	_id bigint NOT NULL IDENTITY(1, 1),
	skuCode nvarchar(32),
	barCode nvarchar(128) DEFAULT NULL,
	[name] nvarchar(64) NOT NULL,
	price decimal(19, 6) NOT NULL,
	category nvarchar(32) NOT NULL,
	subCategory nvarchar(32) DEFAULT NULL,
	[type] nvarchar(32) NOT NULL,
	quantity int NOT NULL,
	isAvailable bit NOT NULL,
	taxType nvarchar(16),
	taxPercent tinyint NOT NULL DEFAULT 0,
	_createdAt datetime NOT NULL,
	_updatedAt datetime NOT NULL,
	_createdBy int NOT NULL /* FOREIGN KEY REFERENCES users(id) */,
	_updatedBy int NOT NULL /* FOREIGN KEY REFERENCES users(id) */,
	CONSTRAINT FK_PRODUCTS FOREIGN KEY (_createdBy) REFERENCES users(_id),
	CONSTRAINT PK_PRODUCTS PRIMARY KEY CLUSTERED (_id ASC) WITH (
		PAD_INDEX = OFF,
		STATISTICS_NORECOMPUTE = OFF,
		IGNORE_DUP_KEY = OFF,
		ALLOW_ROW_LOCKS = ON,
		ALLOW_PAGE_LOCKS = ON,
		OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF
	) ON [PRIMARY]
) ON [PRIMARY];

/* This tables normally are created for usage on a social network */
--CREATE TABLE product_comments (
--	_id bigint NOT NULL IDENTITY(1, 1),
--	comment text,
--	[product_id] bigint NOT NULL,
--	[user_id] bigint NOT NULL,
--	CONSTRAINT PK_PRODUCT_COMMENTS PRIMARY KEY CLUSTERED (_id ASC) WITH (
--		PAD_INDEX = OFF,
--		STATISTICS_NORECOMPUTE = OFF,
--		IGNORE_DUP_KEY = OFF,
--		ALLOW_ROW_LOCKS = ON,
--		ALLOW_PAGE_LOCKS = ON,
--		OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF
--	) ON [PRIMARY]
--);

--CREATE TABLE product_shares (
--	_id bigint NOT NULL IDENTITY(1, 1),
--	CONSTRAINT PK_PRODUCT_SHARES PRIMARY KEY CLUSTERED (_id ASC) WITH (
--		PAD_INDEX = OFF,
--		STATISTICS_NORECOMPUTE = OFF,
--		IGNORE_DUP_KEY = OFF,
--		ALLOW_ROW_LOCKS = ON,
--		ALLOW_PAGE_LOCKS = ON,
--		OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF
--	) ON [PRIMARY]
--);

--CREATE TABLE product_likes (
--	_id bigint NOT NULL IDENTITY(1, 1),
--	CONSTRAINT PK_PRODUCT_LIKES PRIMARY KEY CLUSTERED (_id ASC) WITH (
--		PAD_INDEX = OFF,
--		STATISTICS_NORECOMPUTE = OFF,
--		IGNORE_DUP_KEY = OFF,
--		ALLOW_ROW_LOCKS = ON,
--		ALLOW_PAGE_LOCKS = ON,
--		OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF
--	) ON [PRIMARY]
--);

GO

CREATE TABLE orders (

) ON [PRIMARY];

GO

/* Printed invoices where stores the values contained in the orders table foreign keys  */
CREATE TABLE invoices (

) ON [PRIMARY];

GO

CREATE TABLE payment_methods (

) ON [PRIMARY];