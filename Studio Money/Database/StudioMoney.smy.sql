SET SQL DIALECT 3

CREATE DATABASE 'localhost:C:\Documents and Settings\Daniel\Meus documentos\Visual Studio 2005\Projects\Studio Money\Studio Money\Studio Money\Database\StudioMoney.smy'
USER 'SYSDBA' PASSWORD '**********'
PAGE_SIZE 4096
DEFAULT CHARACTER SET NONE;


/* Tables */
CREATE TABLE "sisContinent" (
  "nContinent"  INTEGER NOT NULL,
  "sContinent"  VARCHAR(50) NOT NULL
);

CREATE TABLE "sisCountry" (
  "nCountry"    INTEGER NOT NULL,
  "sCountry"    VARCHAR(50) NOT NULL,
  "nContinent"  INTEGER
);

CREATE TABLE "sisForm" (
  "nForm"        INTEGER NOT NULL,
  "sForm"        VARCHAR(50),
  "nFatherForm"  INTEGER
);

CREATE TABLE "sisObject" (
  "nObject"  INTEGER NOT NULL,
  "sObject"  VARCHAR(100),
  "nForm"    INTEGER NOT NULL,
  "nType"    INTEGER NOT NULL
);

CREATE TABLE "sisType" (
  "nType"  INTEGER NOT NULL,
  "sType"  VARCHAR(50) NOT NULL
);

CREATE TABLE "tbAccount" (
  "nAccount"       INTEGER NOT NULL,
  "sAccount"       VARCHAR(50),
  "nCurrency"      INTEGER,
  "nInitialValue"  FLOAT,
  "nAccountType"   INTEGER,
  "nBank"          INTEGER,
  "nAgency"        VARCHAR(10),
  "nAccountDigit"  VARCHAR(3),
  "nSpecialCheck"  FLOAT
);

CREATE TABLE "tbAccountType" (
  "nAccountType"  INTEGER NOT NULL,
  "sAccountType"  VARCHAR(50) NOT NULL
);

CREATE TABLE "tbAdditionalUser" (
  "nAdditionalUser"  INTEGER NOT NULL,
  "sAdditionalUser"  VARCHAR(50) NOT NULL
);

CREATE TABLE "tbBank" (
  "nBank"  INTEGER NOT NULL,
  "sBank"  VARCHAR(50)
);

CREATE TABLE "tbCard" (
  "nCard"  INTEGER NOT NULL,
  "sCard"  VARCHAR(50) NOT NULL
);

CREATE TABLE "tbCardEnterprise" (
  "nCardEnterprise"  INTEGER NOT NULL,
  "sCardEnterprise"  VARCHAR(50) NOT NULL
);

CREATE TABLE "tbCardInvoice" (
  "nCardInvoice"     INTEGER NOT NULL,
  "nCardEnterprise"  INTEGER,
  "nBank"            INTEGER,
  "nCard"            INTEGER,
  "nCardMaster"      INTEGER,
  "nAdditionalUser"  INTEGER,
  "nLimit"           INTEGER,
  "dExpiryDate"      DATE,
  "nNote"            INTEGER,
  "dBuyDate"         DATE,
  "nVendor"          INTEGER,
  "nValue"           FLOAT,
  "nPaymentNumber"   FLOAT,
  "nPaymentTotal"    FLOAT,
  "nMinimumPayment"  FLOAT,
  "nPeriodTax"       INTEGER,
  "nRotateTax"       INTEGER,
  "nBillTaxe"        INTEGER
);

CREATE TABLE "tbCategory" (
  "nCategory"        INTEGER NOT NULL,
  "sCategory"        VARCHAR(50) NOT NULL,
  "nCategoryFather"  INTEGER NOT NULL
);

CREATE TABLE "tbCurrency" (
  "nCurrency"  INTEGER NOT NULL,
  "sCurrency"  VARCHAR(50) NOT NULL,
  "sSymbol"    VARCHAR(5),
  "nCountry"   INTEGER,
  "sISOCode"   INTEGER
);

CREATE TABLE "tbInterval" (
  "nInterval"      INTEGER NOT NULL,
  "sInterval"      VARCHAR(20) NOT NULL,
  "nDurationDays"  INTEGER
);

CREATE TABLE "tbPaymentType" (
  "nPaymentType"  INTEGER NOT NULL,
  "sPaymentType"  VARCHAR(50) NOT NULL
);

CREATE TABLE "tbVendor" (
  "nVendor"  INTEGER NOT NULL,
  "sVendor"  VARCHAR(50) NOT NULL
);
COMMIT;

/* Data for table "sisContinent" */
INSERT INTO "sisContinent" ("nContinent", "sContinent") VALUES (1, 'Europa');
INSERT INTO "sisContinent" ("nContinent", "sContinent") VALUES (2, 'Asia');
INSERT INTO "sisContinent" ("nContinent", "sContinent") VALUES (3, 'America');
INSERT INTO "sisContinent" ("nContinent", "sContinent") VALUES (5, 'Africa');
INSERT INTO "sisContinent" ("nContinent", "sContinent") VALUES (6, 'Oceania');
COMMIT;
/* Data for table "sisCountry" */
INSERT INTO "sisCountry" ("nCountry", "sCountry", "nContinent") VALUES (1, 'Brasil', 4);
COMMIT;
/* Data for table "sisObject" */
INSERT INTO "sisObject" ("nObject", "sObject", "nForm", "nType") VALUES (2, 'txtDescription', 1, 1);
INSERT INTO "sisObject" ("nObject", "sObject", "nForm", "nType") VALUES (1, 'txtDescription', 1, 1);
COMMIT;
/* Data for table "sisType" */
INSERT INTO "sisType" ("nType", "sType") VALUES (1, 'Infragistics.Win.UltraWinEditors.UltraTextEditor');
COMMIT;
/* Data for table "tbBank" */
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (1, 'Banco do Brasil S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (899, 'dede');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (29, 'Banco Banerj S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (30, 'Paraiban-Bco do Est da Paraiba S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (31, 'Banco do Est. de Goias S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (32, 'Banco do Est. de Mato Grosso S.A');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (33, 'Banco do Est. de SP S.A.-Banespa');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (36, 'Banco do Est. do Maranhao S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (37, 'Banco do Est. do Para S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (38, 'Banco do Est. do Parana S.A');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (39, 'Banco do Est. do Piaui S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (40, 'Banco Cargill S .A .');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (44, 'Banco BVA S . A .');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (47, 'Banco do Est. de Sergipe S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (59, 'Banco do Est. de Rondonia S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (70, 'BRB-Banco de Brasilia S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (104, 'Caixa Economica Federal');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (106, 'Banco Itabanco S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (109, 'Banco Credibanco S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (116, 'Banco BNL do Brasil S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (150, 'Caixa Economica Est. Minas Gerais');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (151, 'Nossa Caixa - Nosso Banco S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (152, 'Caixa Economica do Estado de Goias');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (153, 'Caixa Economica Est. Rio Gde. Sul');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (154, 'Caixa Ec do Est de St Catarina S.A');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (164, 'Banco Credit Commercial France S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (165, 'Banco Norchem S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (166, 'Banco Inter-Atlantico S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (168, 'Banco CCF Brasil S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (171, 'Banco de Financ. Internacional S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (175, 'Continental Banco S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (184, 'Banco BBA-Creditanstalt S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (199, 'Banco Financial Portugues');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (200, 'Banco Ficrisa Axelrud S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (201, 'Banco Axial S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (202, 'Banco Braseg S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (203, 'Banco Sibisa S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (204, 'Banco Inter American Express S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (205, 'Banco Sul America S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (206, 'Banco Martinelli S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (207, 'Banco Garavelo S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (208, 'Banco Pactual S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (209, 'Agrobanco Banco Comercial S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (210, 'Dresdner Bank L. Aktiengesellchaft');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (211, 'Banco Sistema S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (212, 'Banco Matone S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (213, 'Banco Arbi S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (214, 'Banco Dibens S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (215, 'Banco America do Sul S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (216, 'Banco Regional Malcon S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (217, 'Banco John Deere S . A .');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (218, 'BBS-Banco Bonsucesso S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (219, 'Banco Zogbi S . A .');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (220, 'Banco Crefisul S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (221, 'Banco Fleming Graphus S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (222, 'Banco AGF Braseg S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (223, 'Banco Interunion S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (224, 'Banco Fibra S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (225, 'Banco Brascan S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (226, 'Banco Auxiliar S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (227, 'Banco Rosa S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (228, 'Banco Icatu S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (229, 'Banco Cruzeiro do Sul S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (230, 'Banco Bandeirantes S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (231, 'Banco Boavista Interatlantico S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (232, 'Banco Interpart S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (233, 'Banco GE Capital S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (234, 'Banco Lavra S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (235, 'Banco Liberal S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (236, 'Banco Cambial S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (237, 'Banco Bradesco S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (239, 'Banco Bancred S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (240, 'Banco de Cred. Real de M. Ger. S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (241, 'Banco Classico S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (242, 'Banco Euroinvest S.A.-Eurobanco');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (243, 'Banco Stock Maxima S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (244, 'Banco Cidade S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (245, 'Banco Empresarial S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (246, 'Banco ABC-Brasil S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (247, 'Banco Warburg Dillon Read S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (249, 'Banco Investcred S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (250, 'Banco Schahin S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (251, 'Banco Sao Jorge S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (252, 'Banco Fininvest S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (254, 'Parana Banco S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (255, 'MilBanco S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (256, 'Banco Gulfinvest S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (258, 'Banco Induscred S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (261, 'Banco Varig S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (262, 'Banco Boreal S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (263, 'Banco Cacique S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (264, 'Banco Performance S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (265, 'Banco Fator S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (266, 'Banco Cedula S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (267, 'Banco BBM-Com.C.Imob.C.Fin.Inv.S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (275, 'Banco Real S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (277, 'Banco Planibanc S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (282, 'Banco Brasileiro Comercial S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (284, 'Banco das Nacoes S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (291, 'Banco de Credito Nacional S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (294, 'BCR-Banco de Credito Real S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (295, 'Banco Crediplan S.A');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (300, 'Banco de La Nacion Argentina');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (302, 'Banco do Progresso S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (303, 'Banco HNF S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (304, 'Banco Pontual S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (308, 'Banco Comercial Bancesa S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (314, 'Banco do Comercio e Ind. de SP S.A');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (316, 'Banco Inter-Atlantico S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (317, 'Banco do Comercio S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (318, 'Banco BMG S.A');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (320, 'Banco Industrial e Comercial S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (334, 'Banco Economico S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (337, 'Banco Savena S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (338, 'Banco F. Barreto S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (341, 'Banco Itau S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (344, 'Banco Mercantil S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (345, 'Banco Financial S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (346, 'Banco Frances e Brasileiro S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (347, 'Banco Sudameris Brasil S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (351, 'Banco Bozano, Simonsen S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (353, 'Banco Santander Brasil S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (356, 'Banco ABN Amro S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (361, 'Banco Industrial de Pernambuco S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (366, 'Banco Sogeral S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (369, 'Banco Digibanco S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (370, 'Banco Europeu p/Am.Latina (Beal)S.A');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (372, 'Banco Itamarati S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (375, 'Banco Fenicia S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (376, 'Banco Chase Manhattan S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (388, 'Banco BMD S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (389, 'Banco Mercantil do Brasil S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (392, 'Banco Mercantil-Finasa S.A.-S.Paulo');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (394, 'Banco BMC S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (399, 'HSBC Bank Brasil S.A.-Bco Multiplo');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (405, 'Banco Mineiro S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (409, 'Unibanco-Uniao Bcos Brasileiros S.A');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (412, 'Banco Capital S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (415, 'Banco Nacional S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (417, 'Banco Sul Brasileiro S . A .');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (420, 'Banco Banorte S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (422, 'Banco Safra S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (424, 'Banco Santander Noroeste S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (432, 'Banco Pinto de Magalhaes S . A .');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (434, 'Banfort-Banco Fortaleza S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (441, 'Banco Real de Sao Paulo S . A .');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (446, 'Banco Regional S . A .');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (453, 'Banco Rural S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (456, 'Banco deTokyo-Mitsubishi Brasil S.A');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (464, 'Banco Sumitomo Brasileiro S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (466, 'Banco Mitsubishi Brasileiro S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (472, 'Lloyds Bank PLC');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (473, 'Banco Financial Portugues');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (474, 'Banco de Credito Comercial S . A .');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (479, 'BankBoston Bco Multiplo S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (480, 'Banco Wachovia S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (483, 'Banco Agrimisa S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (485, 'Banco de Roraima S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (487, 'Deutsche Bank S.A.-Banco Alemao');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (488, 'Morgan Guaranty Trust Company of NY');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (489, 'Banco Frances Intern.-Brasil S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (490, 'Banco Residencia S . A .');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (491, 'Banco Maisonnave S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (492, 'Ing Bank N.V.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (493, 'Banco Union, S.A.C.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (494, 'Banco de La Rep. Or. Del Uruguay');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (495, 'Banco de La Prov. de Buenos Aires');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (496, 'Banco Exterior de Espana S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (497, 'Banco Hispano Americano S . A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (498, 'Centro Hispano Banco');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (499, 'Banco Iochpe S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (500, 'Banco Habitasul S . A .');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (501, 'Banco Brasileiro Iraquiano S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (502, 'Banco Santander de Negocios S.A');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (503, 'Banco BRJ S . A .');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (504, 'Banco Multiplic S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (505, 'Banco Credit Suisse F. B. G. S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (600, 'Banco Luso Brasileiro S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (601, 'BFC Banco S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (602, 'Banco Patente S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (603, 'Banco Hercules S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (604, 'Banco Industrial do Brasil S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (605, 'BPA Banco Pao de Acucar S . A .');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (606, 'Banco Grande Rio S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (607, 'Banco Santos Neves S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (608, 'Banco Open S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (609, 'Banco Adolpho Oliveira e Assoc.S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (610, 'Banco VR S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (611, 'Banco Paulista S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (612, 'Banco Guanabara S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (613, 'Banco Pecunia S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (616, 'Banco Interpacifico S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (617, 'Banco Investor S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (618, 'Banco Tendencia S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (621, 'Banco Aplicap S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (622, 'Banco Dracma S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (623, 'Banco Panamericano S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (624, 'Banco General Motors S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (625, 'Banco Araucaria S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (626, 'Banco Ficsa S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (627, 'Banco Destak S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (628, 'Banco Criterium S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (629, 'Bancorp - Banco Com. e de Inv. S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (630, 'Banco Intercap S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (631, 'Banco Columbia S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (633, 'Banco Rendimento S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (634, 'Banco Triangulo S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (635, 'Banco do Est. do Amapa S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (637, 'Banco Sofisa S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (638, 'Banco Prosper S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (639, 'Big S.A.- Banco Irmaos Guimaraes');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (640, 'Banco Credito Metropolitano S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (641, 'Banco Bilbao Vizcaya Brasil S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (642, 'Brasbanco S.A. - Banco Comercial');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (643, 'Banco Pine S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (645, 'Banco do Est. de Roraima S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (647, 'Banco Marka S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (648, 'Banco Atlantis S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (649, 'Banco Dimensao S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (650, 'Banco Pebb S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (652, 'Banco Frances e Brasileiro S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (653, 'Banco Indusval S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (654, 'Banco A.J.Renner S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (655, 'Banco Votorantim S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (656, 'Banco Matrix S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (657, 'Banco Tecnicorp S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (658, 'Banco Porto Real S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (702, 'Banco Santos S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (705, 'Banco Investcorp S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (707, 'Banco Daycoval S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (711, 'Banco Vetor S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (713, 'Banco Cindam S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (715, 'Banco Vega S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (718, 'Banco Operador S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (719, 'Banco Banif Primus S . A .');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (720, 'Banco Maxinvest S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (721, 'Banco Credibel S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (722, 'Banco Interior de Sao Paulo S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (724, 'Banco Porto Seguro S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (725, 'Banco Finansinos S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (726, 'Banco Universal S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (727, 'Banco Comercial de Sao Paulo S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (728, 'Banco Fital S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (729, 'Banco Fonte Cindam S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (730, 'Banco Comercial Paraguayo S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (731, 'Banco GNPP S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (732, 'Banco Minas S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (733, 'Banco das Nacoes S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (734, 'Banco Gerdau S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (735, 'Banco Pottencial S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (736, 'Banco United S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (737, 'Banco Theca S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (738, 'Banco Morada S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (739, 'Banco BGN S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (740, 'Banco Barclays e Galicia S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (741, 'Banco Ribeirao Preto S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (742, 'Banco Equatorial S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (743, 'Banco Emblema S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (744, 'BankBoston N.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (745, 'Banco Citibank S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (746, 'Banco Modal S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (747, 'Banco Rabobank Internat Br. S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (748, 'Banco Coop. Sicredi S.A.-Bansicredi');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (749, 'BR Banco Mercantil S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (750, 'Banco Republic Nat. OF NY-BR S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (751, 'Dresdner Bank Brasil S.A. B.Mult.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (752, 'Banco Banque Nat. Paris BR S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (753, 'Banco Comercial Uruguai S.A.');
INSERT INTO "tbBank" ("nBank", "sBank") VALUES (755, 'Banco Merrill Lynch S.A.');
COMMIT;

/* Constraints */
ALTER TABLE "sisContinent"
  ADD PRIMARY KEY ("nContinent");

ALTER TABLE "sisCountry"
  ADD PRIMARY KEY ("nCountry");

ALTER TABLE "sisForm"
  ADD PRIMARY KEY ("nForm");

ALTER TABLE "sisObject"
  ADD PRIMARY KEY ("nObject");

ALTER TABLE "sisType"
  ADD PRIMARY KEY ("nType");

ALTER TABLE "tbAccount"
  ADD PRIMARY KEY ("nAccount");

ALTER TABLE "tbAccountType"
  ADD PRIMARY KEY ("nAccountType");

ALTER TABLE "tbAdditionalUser"
  ADD PRIMARY KEY ("nAdditionalUser");

ALTER TABLE "tbBank"
  ADD CONSTRAINT "PK_tbBank"
  PRIMARY KEY ("nBank");

ALTER TABLE "tbCard"
  ADD PRIMARY KEY ("nCard");

ALTER TABLE "tbCardEnterprise"
  ADD PRIMARY KEY ("nCardEnterprise");

ALTER TABLE "tbCardInvoice"
  ADD PRIMARY KEY ("nCardInvoice");

ALTER TABLE "tbCategory"
  ADD PRIMARY KEY ("nCategory");

ALTER TABLE "tbCurrency"
  ADD PRIMARY KEY ("nCurrency");

ALTER TABLE "tbInterval"
  ADD PRIMARY KEY ("nInterval");

ALTER TABLE "tbPaymentType"
  ADD PRIMARY KEY ("nPaymentType");

ALTER TABLE "tbVendor"
  ADD PRIMARY KEY ("nVendor");

COMMIT;
/* Foreign Keys */
ALTER TABLE "tbAccount"
  ADD CONSTRAINT "nAccountType"
  FOREIGN KEY ("nAccountType")
    REFERENCES "tbAccountType"("nAccountType")
    ON DELETE CASCADE
    ON UPDATE CASCADE;

ALTER TABLE "tbAccount"
  ADD CONSTRAINT "nBank"
  FOREIGN KEY ("nBank")
    REFERENCES "tbBank"("nBank")
    ON DELETE CASCADE
    ON UPDATE CASCADE;

ALTER TABLE "tbAccount"
  ADD CONSTRAINT "nCurrency"
  FOREIGN KEY ("nCurrency")
    REFERENCES "tbCurrency"("nCurrency")
    ON DELETE CASCADE
    ON UPDATE CASCADE;

ALTER TABLE "tbCurrency"
  ADD CONSTRAINT "nCountry"
  FOREIGN KEY ("nCountry")
    REFERENCES "sisCountry"("nCountry")
    ON DELETE CASCADE
    ON UPDATE CASCADE;
