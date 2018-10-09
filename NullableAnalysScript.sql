﻿ALTER TABLE [dbo].[BeltAnalysis] ALTER COLUMN [AshAvg] [real] NULL
ALTER TABLE [dbo].[BeltAnalysis] ALTER COLUMN [AshMax] [real] NULL
ALTER TABLE [dbo].[BeltAnalysis] ALTER COLUMN [SulfurAvg] [real] NULL
ALTER TABLE [dbo].[BeltAnalysis] ALTER COLUMN [SulfurMax] [real] NULL
ALTER TABLE [dbo].[BeltAnalysis] ALTER COLUMN [MoistureAvg] [real] NULL
ALTER TABLE [dbo].[BeltAnalysis] ALTER COLUMN [MoistureMax] [real] NULL
ALTER TABLE [dbo].[BeltAnalysis] ALTER COLUMN [VolatileMatter] [real] NULL
ALTER TABLE [dbo].[BeltAnalysis] ALTER COLUMN [Caloricity] [real] NULL
ALTER TABLE [dbo].[BeltAnalysis] ALTER COLUMN [CaloricityMax] [real] NULL
ALTER TABLE [dbo].[BeltAnalysis] ALTER COLUMN [RockPerc] [real] NULL
ALTER TABLE [dbo].[BeltAnalysis] ALTER COLUMN [SmallFractPerc] [real] NULL
ALTER TABLE [dbo].[BeltAnalysis] ALTER COLUMN [xValue] [real] NULL
ALTER TABLE [dbo].[BeltAnalysis] ALTER COLUMN [yValue] [real] NULL
ALTER TABLE [dbo].[SkipAnalysis] ALTER COLUMN [AshAvg] [real] NULL
ALTER TABLE [dbo].[SkipAnalysis] ALTER COLUMN [AshMax] [real] NULL
ALTER TABLE [dbo].[SkipAnalysis] ALTER COLUMN [SulfurAvg] [real] NULL
ALTER TABLE [dbo].[SkipAnalysis] ALTER COLUMN [SulfurMax] [real] NULL
ALTER TABLE [dbo].[SkipAnalysis] ALTER COLUMN [MoistureAvg] [real] NULL
ALTER TABLE [dbo].[SkipAnalysis] ALTER COLUMN [MoistureMax] [real] NULL
ALTER TABLE [dbo].[SkipAnalysis] ALTER COLUMN [VolatileMatter] [real] NULL
ALTER TABLE [dbo].[SkipAnalysis] ALTER COLUMN [Caloricity] [real] NULL
ALTER TABLE [dbo].[SkipAnalysis] ALTER COLUMN [CaloricityMax] [real] NULL
ALTER TABLE [dbo].[SkipAnalysis] ALTER COLUMN [RockPerc] [real] NULL
ALTER TABLE [dbo].[SkipAnalysis] ALTER COLUMN [SmallFractPerc] [real] NULL
ALTER TABLE [dbo].[SkipAnalysis] ALTER COLUMN [xValue] [real] NULL
ALTER TABLE [dbo].[SkipAnalysis] ALTER COLUMN [yValue] [real] NULL
ALTER TABLE [dbo].[WagonAnalysis] ALTER COLUMN [AshAvg] [real] NULL
ALTER TABLE [dbo].[WagonAnalysis] ALTER COLUMN [AshMax] [real] NULL
ALTER TABLE [dbo].[WagonAnalysis] ALTER COLUMN [SulfurAvg] [real] NULL
ALTER TABLE [dbo].[WagonAnalysis] ALTER COLUMN [SulfurMax] [real] NULL
ALTER TABLE [dbo].[WagonAnalysis] ALTER COLUMN [MoistureAvg] [real] NULL
ALTER TABLE [dbo].[WagonAnalysis] ALTER COLUMN [MoistureMax] [real] NULL
ALTER TABLE [dbo].[WagonAnalysis] ALTER COLUMN [VolatileMatter] [real] NULL
ALTER TABLE [dbo].[WagonAnalysis] ALTER COLUMN [Caloricity] [real] NULL
ALTER TABLE [dbo].[WagonAnalysis] ALTER COLUMN [CaloricityMax] [real] NULL
ALTER TABLE [dbo].[WagonAnalysis] ALTER COLUMN [RockPerc] [real] NULL
ALTER TABLE [dbo].[WagonAnalysis] ALTER COLUMN [SmallFractPerc] [real] NULL
ALTER TABLE [dbo].[WagonAnalysis] ALTER COLUMN [xValue] [real] NULL
ALTER TABLE [dbo].[WagonAnalysis] ALTER COLUMN [yValue] [real] NULL
INSERT [dbo].[__MigrationHistory]([MigrationId], [ContextKey], [Model], [ProductVersion])
VALUES (N'201804031430022_nullableLabAnalys2', N'CTS_Manual_Input.Migrations.Configuration',  0x1F8B0800000000000400ED5D5B6FE4B8B17E3FC0F90F8D7ECA09366EDB8B0536033B81D733B330B273C9B467933743EEA66D61D5521F493DB0119C5F761EF293F21742DD79A9E245A2A496230C3070F352248B1FABC86215F5AFFFFFE7C59F9F77C1E21B89133F0A2F976727A7CB050937D1D60F1F2F9787F4E10F3F2EFFFCA7FFFEAF8B77DBDDF3E2D7AADCF759395A334C2E974F69BA7FB35A259B27B2F392939DBF89A3247A484F36D16EE56DA3D5F9E9E91F5767672B42492C29ADC5E2E2CB214CFD1DC97FD09FD751B821FBF4E0051FA22D0992329DE6AC73AA8B8FDE8E247B6F432E97D7B7EBBB0F5E48CBDEDD84FB437A5254592EAE02DFA3DD5993E061B9F0C2304ABD9476F6CDD784ACD3380A1FD77B9AE005B72F7B42CB3D784142CA41BC698A9B8EE7F43C1BCFAAA95891DA1C9234DA59123CFBBE64D04AACDE8ACDCB9A819485EF28ABD3976CD4391B2F973F91205D6FBC808E5E6CEDCD751067254B36E79C3DA9CB7FB76852BFABC1403193FDA39987203DC4E432248734F682EF169F0FF781BFF90B79B98D7E23E165780802B667B46F348F4BA0499FE3684FE2F4E50B7928FB7BF376B958F1F55662C5BA1A53A718C84D987E7FBE5C7CA48D7BF701A9279E19F43A8D62F2330949ECA564FBD94B5312D379FB1885446A596827FBBF6A89A28CAE9AE5E283F7FC0B091FD3A7CBE5F90F3F2C17EFFD67B2AD52CAD6BF863E5D64B4521A1F8C1A79975146DBA17F3A68E797689333A4615E6F437A1F47BB9B9072FC2D495269B2D4756F23E39A1FBD6FFE633E2655FBCBC51712E4A592277F5F889006F57742D9ECE797286017125FE46E1D1DE24D068B485DEED68B1F496ADEE96A7E34FD6D8A415DAD7215BDAC8BD8769099194D1FB992503799028A9EB2A5A0CE5EAC1AE9A7948935193F2C7967241AC56AB3849C2564DB21B55BF62202C1D58F169296165EB2D3F26A3A65B4ACAAE2935C4E1D10D1D312ACD839C852641B532F4937EDBDA568F2FB189A31B83375741B7B61F240628B2D7555E5B580FCECFCC77620D7E1291D08B7E95F0F5E3EB7755BB4A5C0BEC7B774E60391D6DB884E9BB6EA75B4DB9130ED7DB09FF6991889E26138EB25EFB67EFA96CAAD5BBF69AFF96DCBDF72E16495D7A9B7DB77A6586F282D4F2237C9AF5EE06FAB3A3F4554877AA175F33729D959B69CF5F82AF48297C44F5A1F825822E87EBD2A70C7CAAC44DCB4C3A5EA4D03BB73478A563B119BCE97560CA4E715ED3BA628DF6BB90478D6008AD99E8CB229D677B42885F431CB54772F2FD1699FC623C25895555526A9CADA1F7F6EB6A494F1EAC52A2F54977B44B3B6DD094BD7E2FC55EA3C479AE12A79BAFAF628EE47B475F2C3AE4D9DF5217838C4D64D15D5AC5BFB10F9492608ACDBAB2A5AB7F86B9409DE8056CC96AE5DDD6B2F88627F03EC0B4DEB5977F74BB4F9ED33893796B3B1F382E07DEC6D52FBBACF14AE076257E7C5A48E527F33DB893E761F90B2D46C54DA190F73B56D6630A445FFC3B4E46C24EC6F483FC7DE56C5B896036A698ACCB69FA0F991CD904D8E5C6EA785B8FECDDF1B2EC4ACE8BC105BAC11776B71D20BB1DD12C950072E112E435A227C6EE7256269AC64AB4C72C90C68ACF41F52DAD41807BDE3B7B2BDCA835EB638C6B11A662D773601161A139154B561A928C54B2B2E1394587C095B8B193B3CB487F56E9E6D2F11BB0A97928C938AA29071D24AE45A1AD5D82A9314B9B3516D36AACD46B5D9A886E27336AAC175BA19D50435D887D68434BD46C1B6D29A5F1312672D186ACCAAF8AC2D6118BF2429D9393A755BCADBC243279B9C21DA3706D8AFE4C9B77183AFCBFF87416CB6DF8E6E36AAA107DA8EE45C494803453A09E78C9EA51589AD32C915349C15E9362AFCE27B5E4F35282CED1719F2F8E08B3E9DF21C89165B8FB0F890A6514747C0577908A37243DA9EF6EFEF76FCD6CDB687536588121A49C34AD3BBA624AF14A402A05E904B39736EE3C88BCE6D52A6BA77A8739BAA67CC1E4FD73DA628D2C746892A3BDA14EBA462FFE63D46A1CDFEB4A93049F53A6F5027BC416DB007EE50816C690D4165BA2F20CB4D2A576792CB68B85DEA9A0E77A0D88C62433CC07EB301A1E5FE24AF687A1B37EFA7E7FDF4BC9F3EAAFD3427F8C10D355C0256633D6EA979FAE29E5ACED574B0D5AEBAB24F68BB5715C43A58E46BBA5816B2ED242791F1BED657175CA389D467A49CE444A02C6C1BE3C49E01B4CC660B630C6736596AA63305BB6FC22C9D1FB83A93DC84CDDE0FB3F7C3ECFD307B3FA0F89CBD1FE03ADDBC1F4415DE97CE0755A76E8360A23EAF9224DAF8799FAB458F3EEFC2F3E45DB85D18BFF55230177A3D868A2DAA50FD7D9083EC72F97B89F9260DD57BA2A6A1C62AC437707A727226B541D53089333DE805D774F6A862F7C354D6D97EB8F1F75E60DA1D8180A1DACF26AB6E4ACC794BF624CC34B629EF4DFAC05AF7E4BED44D0A9B131DCF2E560CB8D498C35E3EC380A07D06AD810113896F0E34DDF36916787607374DA706009B86ED263D905EE11B196F5AE1A67AC6CE19CAC69563783F06C5D4C42517FBBEA07EC6C1C7069DE1097AA47064990574695074010C37695F78F973348C5DC151E92A28C05530B4351613032C183504008F7FB74C87ECD688538F7C20D8A9B962D209F1C5A5D1C0073C6BA4C283EA8DA3B658D0B680A00D14A26EE51BDE99819086F3DB1465F5FDE32810E3A3F8D1C31F1CD2CF68B5FC66C2E23409BE0230EC0912EAC210A746889793D96FF17751467282BF97722C84B81B2D0D207B123D6C1786963A2C6F8DDA2EEF8E47C10FFF1C0236BDC8DB08CDD416E1C9E678819F531854D6805D18002B202F27216BE48074D5F422D1E93C66DAC81A3CB05D0348B7D801BB30107E40DE9AB45DBD95301A7EAEE0C047D55CC3553044B53CB7993C52D016BAAD21A61EF940585373C51474A39FDB80002E0C0BAA68AE06038CB7BAB9EC5244810DAAFCF07E0C802A9CBF93508370E0876AC6153E6B3C9EDAA8437500C9E0A842BB3210B0505E9BB4CFFA018F8F2DE5714E11BBE31853E31CE7D02E0C8DA3491DE790782AA3790682AB1C23498ECB32D1A73D614AEACCD0C092F86DD2012E62781488418146D8EC2BA38E9AA967FD66CDA1A50A571A54ED293A3200A6143C9EC4760AF1FB57CEBAD1864A883EB304D6916CA9D47D190A5ED3DE5401011B66538F6DAB1C216B9C8D15DE87C1D134A9AD1518576336D162908D732409013A234A28BE2783238AE7B449F34D60EB78A8C2BCA19593AF758D1650D6D2306A167AD51AD1ED21A719FF50D0D3B0C6A41B52E4F211C837664B6E2682A0B836E7720E8889333A46F425EDE4FE0C2EF164BE1B436EC87364116D41EBA4B40689AB6E10FFF129CD52C9730AC4267E4D48199E9894115A224E32AA6B928ABE3B54CA35F11DB2FB9304379E8CE80F0A51937D4635442B4D0C116BB4B4B6675990A217301133E0389BA5A621C8BB3A82B49A6C5DE7E8F60C6455BE9FD554CE2E89A0CAC545AE4165154BF8FB3A03620A96F0D91A5AD59BA810A1E679550D91DAE6035161CC660664544CE24D7C1A628D008148B192D88490AA5B82EA3021A7983D215FA0C6082F5C1A30EFEB30E511B180D8C8381DA78F17AB4709CA26497CDB448831A4190925065EF38C31601A16C104B0CC28D8891B952EDC891913AB11147CD20538D94C40276EA9B0A58BD24146A44293357B86C70F1B47A2640A1A70820C050A39E9C21A28C86400DC20911008AB4CE226A4F169222704A661D2D5942CC83B69DBE3847780233FC2379DCBBF343885D3BFCDC04CE8020CC3C1DB8253C257E500A5873BACF3DA08745967D951EC20550A0D7452EF5108F176631D3A64E3323E819C75D90D26388BB28EAF2D18227C3C4D6686C29D98EB35EC50CCF4B83C0E28060EBB10F78404E05B4CF0E015FEB152EF610F5981096628C07D62753C6DC90CC48F13E18A89D7A7341E8DDFA7303023AD63E0E569CAFE167C83DE9097F9A57354E406A470556406C21E2015DC513827F6B4AC90379461A668EE88A5A1E097C4026BCC9698DACF6E0806611A48E334868F02D3402D99D2B7F6C11E8BD670047183C2C7213B4275E78DECFA64B43E5B70097C08586691D68D4736C3EB050D671552B046E5BAD3D34AC29E97443863236C342E29227FCCD0A3714219844B98C0D13954280682899CD69CE95BE8C0CF69EA7802B907983B08B8E08BE012D0275EB0EB6B8C4B46D7DDF617DE22D78C768446D7DBC6F3D1195FACE15C8731EC8AD6EE92D605D6806B5933A5A0E057F5405B7D6558E75DACD69B27B2F3CA848B152DB221FBF4E005C523A555C6076FBFF7C3C7A4A959A62CD67B6F434771FD87F572F1BC0BC2E472F994A6FB37AB5592934E4E76FE268E92E8213DD944BB95B78D56E7A7A77F5C9D9DAD76058DD58603AC78C159B79446B1F74884DCEC7DCC2D79EFC749F6E2A677EF658F465E6F775231FE8214B9FAA8DA92EE40E5F9AB6E43AA2AD9DFE5C386D91BAF5E4899787713EE0FE949F9142C6AEF6AD8F99E8E307BEC331F2C81AC50725D5A3BCBF162E005D7EB2838EC42FCAE1CAF5DBC02CAD62F52EC28E41F901089E489E67458B75A9694CADD16A726BD12C692D43E2186D3155EF361A96A1EFAC9D69D30FD921381043761ED8B003682B76C46778172E936DF1EEC7A1233E68F0847CD2EC8057EB02394016EF0AAFDE0A56A4FC60D9FD38EA2842329D39C6EF1D552B99F6CFAD1E049B6DABBD2BEB5EF433B058C57EF0B5F2904ADD41E55E95F0F5E583CC52ED06A326C745DEA05304521CB9C66FDCA394BAD4E34A7C3BF62CE12E3732CB827BEE7CE7150CCB4E0628926E6E5798E9372B6396DEEE52D96AAF2492E058EABE7DA393057891674CAB0038E0C128AA01E1DEBE42B0E50E5003C9A54E3EEF35D09348CA0A140C3ABF723D0B049534F988E1AB28080ECF117FDF18A39574BBCFA24033715659A1595FCAB0002953CCD9C0AF3D9069610936C4B4BEA14936C4E8BFBC0034B8DCBB0A727F58ECB30A7277E0E822529E659609FF95004077F26BD0D3569D4429639CDE6BB122CB926D5022DC2B72638C80879E654ABAF50B0D4AA34732A2F00951794CA588780FCD2C1894102B85431314280D566C3830DB59F636F2B0CAC4C3A1A9C159E3C2E7006B92919E00CAED61FCE5CA0A43B5E2765E0D2B95AB5C34A076384BA7A4FC608FF21A57D9226AC491E7F77DDE791FA7877EED54B94DC1E03799D52810E47FB7FF18942B157477938E7DC1E5D2DF00E877375F5F9703E1FCEE7C3F97C389F0FE7F3E17C1475D9C462BBD09575F4B6BD9EC4ABF6A323D72F494A76B25C67D36D6F65B3FECB14C5BCA3997BC6C3DAC5E4A32EE506B3AFA83BDB698E0C326ECFCFDC030BED8033F4F9B9F277E66FCB8B340BE5CF3E5ACA697ED56BA6383DF64541D113CEDE09CE95C3C24FF1214D23E162B74C7B0DDBF95B2F16281529435FA44FD10E637B141A49E6B1AEDA2E241EEEA26E20EF5495674D796CA871AB2AF9477F5A62676865B93EDC07902E61D36D55AFEC966DAFE0F8C7DE586AEA67E0341431D39BF639439CEEACD8F57466C53E2BF67622DAE95D8192A2A9849E6F0BE6DB82F9B6C086D67C5B30DF1618A165BE2D10F2418D2945198B45EAD6CB94FA771D655C46F872A1C7F9C8B340E27CC449196D2C86FC1645960BCA9E6FFE360BF72D2CF227598193F5FF06D7819F8BE5AA00D5C3FE03DD06DF46BF91F072797E7A76BE5C5C05BE971401E26530F31BF11D65A3E8E6B3EFB3E866B2DDADC4EAF631D2199524D906408474364DD5BE1A0E0FBEF80B7911E7B84290EA11ED8B9558F102D83C146FC1FA195B3F1E82C0BBCFC2D91FBC20919FAA05AD0345FDF09B176F9EBCEC2973EFF917123EA64F743E7EF881259ABF576D4033370DF0647FB7F39EFFC796166B1B107B29BDAC7D136EC9F3E5F21F79DD378B9BBFDF35D5BF5B7C8A29DADE2C4E17FFD77580527032C37F834E09D5F99ED9F5440868B6EB0757D9BC17AC6C522E0575F0F0BC2226BB228C11807C4B6D80993799392338F0F1C36E61218511BB25CF861477A16C3CDD7864EE68537E76FE638B294FFB996D26C4B7201D132FB0EE9E10D85B507A08222FB5ED517D44763B50FEB0EC9889A295A020BFA5BFD3FCB72D33653B59478A5C5CAF9D4266AA76D914D4F685A2F57BDF5E0956764EBBFE17B5BA745D8C19B6E75F53BB871D0D1EA93BD86E263739FE4CC26C8991EDE7DC5E40CF4237D9776D72796039D332B79DA94EC056D8716DB95EFD1314800E1677653884759049272AA3617B0A8CB5B02B918E3DE1AC83DDC974EC8D68086C4F893500BAA0D271608DBDAFC37C0B36BEF6942AFB5E7B0A2F9614CC4FCDF2A75CE793F2544FCA72A7CAA85BEBE119E3478E623D66FCF470EC85603955FC58CDFA6B387A3731ACAEED38477F709CE066B48A6DB53BA615B5463EE18A01B0F643E8F5A489879DCE27CDF9A4399F34E793E67CD24408CD274D431D03876C4E56BFB0919F9ADDBF113D31EED39EA6F14C20E193C77C709B0FFE6E16211E0039A9835B153FE916145C28A5DD0E9DA9DAE5A4C10669B4805253DDA50DA9C505B5D9D56519FFD1E1727A82FBDC222EA4C398C7BA2C3D7E9386F511C2586C627194B3CA7CFD2A53110739299DC986503A166951079D555576A9B1F8984C3B41C9D6ED222EA510CE16DD6863F39B3715F3A662DE544C6653315BDD6D49CF567787B467ABFB6C759FADEEAFC7EACE7C0BB65AE1425814F2A972E6C3B4CD27CF8BDEE4DFCD6D123F1C82D4DF07F92C5E2E4F4F4ECEA4C135B4A4A02C96A69CC9D3FEBD4498EA3E1267AAC90BAEA3304963CF9783593FC77EB8F1F75E208E472868A8533366D724C59CB7644FC24C5962E3356953F522D1C5AA6E42D0F43A5E701F065663A48E04E083055184749A550D629A8856962893DA0B465ACD5B47ACA83E0B2C37A6FD44EDC04819548C8C038A2105871D188E48623061BDB3BC382288683E3E3D184AAA63DB1D1BAE291E77F9E9ACCFC4E28C3619D610A90DB822CD26A317A0683ED6D80B48148FFEC9EDE9BE9B391850AA5EDF616F5AB45EF3470E0FF3353D0636D0A70D07014666611CF8C49205C470FA294F98FC0603F91ADE91EE2D6A6100C42759CED511AF7EE339197AE1630F4F0E32FF9933FAB06B3E0F6262E91409935FF3C897098F70CDB3014577404C99E55C19CC37B8E6F98C5EE6DF784E1CCCBDD59AC7BE1C37D8FCD72705C567178549044F0A7CC6A48031E449A11540463F29D48E96C36A88C6659A25C6A44E5E57A8BEC773840A837564AE5D540683022823F88C5701082BF9A07A617E784CF47E70181307431D1CAC3130EAC1819B7F2CC8A5B54C3F6238D8C9EEA131A1FC42D520C0687C3A87DD35306EE32C353679F26A42F97DA223DC3870EEDCC3EE1C784F720911AF68EFA0FBF6D0116E1E785CF4BE7B18170B43ED1FEC7130EA0682C7401964384B867111817FAE6B384CD4A629D577DAC4F9048D5342CE8450A2FB5AD1114045FBD9B411A4081A3AD8619B78FC3819EC34D21224439E4784CFA3D4C102C2A74C2478945F5C11EFE2978BC6F557F67C283E8872B9DCDE67415085FB709D9D00A0E15B919DB1A4C6E422509B62297DD38DEA949A6CB2A0A6AA5C7D13FC952EC8C6261BE36423FD4D9A6B443DD85C938D35D794D04D5DBE0995A72B4F06A788E6E8C916D76B12D92219229BE59891554C059F8D35633E15FC9D10D89C7A2AF8129AD6EAA76EE4969A2CA8952A57DF0463A692DA60F2A046EA6CB35614B3C467636D99CF12ABF1A4C6D84CA829F6C3CB460D290626E4A3CD590E4D8140211F6D11C520A37C7071DE98BF164C7944B023B632E410540F984D94B4ABCA2798A120678A718EFC700D5881C538008C300A877037188E92A4E673124CAA4346A8C0A073F47784822187CB7AAA2B478CBAB44F7ACE11476C8413266EDBD22044F9568F03935A12055126D7149A0C27CC009C8D1146E8DC92BBCCE428C3E75D6A213D80FBDCBA92FDCC56B5582E7982DB992D686A26153284DA76749459E49D2481612ABC281DCD227B32C86B15094E86C6FB0222C353380CDA7754AA01CE229FE164A888DB1B32661327396928A05C569D68466106E0DA053041E700E608DCD2F92AAFCAA43A19AE7C0F898C587361E970D0E04CF3196E878EC9698D374F47393DCA5019F868C68B7A74B487E828C3873C2F80B16B1D341C015C3630E475D9643743365AD826AE082E070E4EB890E378F8D8E2D6DDB6775CDD630DB77A97563760E86A799A338DDD8C622C30BA4955DDA58A0332DAC28C850756B0E83081DF9B7511603DB3A17A87A6BEDDAAF32E56850DB34CA03FD328F61EC987684B82244FBD587D3984D94B5BC52FBA24FCC786C405A519920D779B5697B9091FA2EA6A4FE85155447C5189A4DED64BBDAB38F51FB2377FE2684392C4CF5E34CD1FDFB95CBEDBDD93ED4DF8E990EE0F291D32D9DD072F2C33B2CB4155FB172BA9CF179FF6F9DD948B21E44F757929F914FE74F0836DDDEFF7C023740889ECD6B17CEE2D9BCB347BF6EDF1A5A6F4310A0D0995ECAB2F4B6FC96E1F5062C9A770ED7D236DFAF63521BF90476FF342D3BFF9DB0C871811FD44F06CBF78EB7B8FB1B74B4A1A4D7DFA936278BB7BFED3BF01CFE5F369485C0100 , N'6.1.3-40302')