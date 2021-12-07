﻿// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using D05;

var input = new[]
{
    // new Tuple<XY,XY>(new XY(0,9), new XY(5,9)),
    // new Tuple<XY,XY>(new XY(8,0), new XY(0,8)),
    // new Tuple<XY,XY>(new XY(9,4), new XY(3,4)),
    // new Tuple<XY,XY>(new XY(2,2), new XY(2,1)),
    // new Tuple<XY,XY>(new XY(7,0), new XY(7,4)),
    // new Tuple<XY,XY>(new XY(6,4), new XY(2,0)),
    // new Tuple<XY,XY>(new XY(0,9), new XY(2,9)),
    // new Tuple<XY,XY>(new XY(3,4), new XY(1,4)),
    // new Tuple<XY,XY>(new XY(0,0), new XY(8,8)),
    // new Tuple<XY,XY>(new XY(5,5), new XY(8,2)),
    
    new Tuple<XY,XY>(new XY(682,519), new XY(682,729)),
    new Tuple<XY,XY>(new XY(852,131), new XY(25,958)),
    new Tuple<XY,XY>(new XY(303,481), new XY(206,481)),
    new Tuple<XY,XY>(new XY(199,682), new XY(183,666)),
    new Tuple<XY,XY>(new XY(363,190), new XY(571,190)),
    new Tuple<XY,XY>(new XY(930,290), new XY(221,290)),
    new Tuple<XY,XY>(new XY(364,627), new XY(952,39)),
    new Tuple<XY,XY>(new XY(234,309), new XY(234,821)),
    new Tuple<XY,XY>(new XY(130,864), new XY(130,886)),
    new Tuple<XY,XY>(new XY(462,347), new XY(699,110)),
    new Tuple<XY,XY>(new XY(375,969), new XY(481,969)),
    new Tuple<XY,XY>(new XY(989,859), new XY(275,145)),
    new Tuple<XY,XY>(new XY(221,748), new XY(212,748)),
    new Tuple<XY,XY>(new XY(870,173), new XY(106,937)),
    new Tuple<XY,XY>(new XY(604,33), new XY(604,142)),
    new Tuple<XY,XY>(new XY(780,35), new XY(780,206)),
    new Tuple<XY,XY>(new XY(636,808), new XY(721,808)),
    new Tuple<XY,XY>(new XY(944,989), new XY(334,989)),
    new Tuple<XY,XY>(new XY(477,113), new XY(192,113)),
    new Tuple<XY,XY>(new XY(879,265), new XY(879,358)),
    new Tuple<XY,XY>(new XY(754,974), new XY(17,974)),
    new Tuple<XY,XY>(new XY(10,989), new XY(989,10)),
    new Tuple<XY,XY>(new XY(337,320), new XY(674,657)),
    new Tuple<XY,XY>(new XY(225,96), new XY(557,428)),
    new Tuple<XY,XY>(new XY(129,354), new XY(299,354)),
    new Tuple<XY,XY>(new XY(717,695), new XY(695,695)),
    new Tuple<XY,XY>(new XY(94,255), new XY(317,478)),
    new Tuple<XY,XY>(new XY(90,87), new XY(90,187)),
    new Tuple<XY,XY>(new XY(77,942), new XY(952,67)),
    new Tuple<XY,XY>(new XY(804,315), new XY(989,315)),
    new Tuple<XY,XY>(new XY(619,470), new XY(491,342)),
    new Tuple<XY,XY>(new XY(466,90), new XY(466,755)),
    new Tuple<XY,XY>(new XY(840,121), new XY(840,469)),
    new Tuple<XY,XY>(new XY(638,127), new XY(638,77)),
    new Tuple<XY,XY>(new XY(844,40), new XY(151,40)),
    new Tuple<XY,XY>(new XY(653,987), new XY(653,631)),
    new Tuple<XY,XY>(new XY(195,583), new XY(195,623)),
    new Tuple<XY,XY>(new XY(88,985), new XY(570,503)),
    new Tuple<XY,XY>(new XY(921,897), new XY(165,141)),
    new Tuple<XY,XY>(new XY(230,27), new XY(171,27)),
    new Tuple<XY,XY>(new XY(737,771), new XY(832,771)),
    new Tuple<XY,XY>(new XY(563,365), new XY(665,467)),
    new Tuple<XY,XY>(new XY(942,940), new XY(776,774)),
    new Tuple<XY,XY>(new XY(12,903), new XY(644,903)),
    new Tuple<XY,XY>(new XY(308,390), new XY(308,971)),
    new Tuple<XY,XY>(new XY(572,943), new XY(572,15)),
    new Tuple<XY,XY>(new XY(104,389), new XY(104,73)),
    new Tuple<XY,XY>(new XY(346,721), new XY(974,93)),
    new Tuple<XY,XY>(new XY(30,53), new XY(562,53)),
    new Tuple<XY,XY>(new XY(804,682), new XY(804,120)),
    new Tuple<XY,XY>(new XY(952,45), new XY(15,982)),
    new Tuple<XY,XY>(new XY(475,456), new XY(475,348)),
    new Tuple<XY,XY>(new XY(409,247), new XY(664,247)),
    new Tuple<XY,XY>(new XY(345,18), new XY(816,489)),
    new Tuple<XY,XY>(new XY(571,158), new XY(505,158)),
    new Tuple<XY,XY>(new XY(59,195), new XY(27,195)),
    new Tuple<XY,XY>(new XY(230,681), new XY(23,681)),
    new Tuple<XY,XY>(new XY(258,711), new XY(921,711)),
    new Tuple<XY,XY>(new XY(658,112), new XY(366,404)),
    new Tuple<XY,XY>(new XY(842,220), new XY(842,825)),
    new Tuple<XY,XY>(new XY(815,744), new XY(540,744)),
    new Tuple<XY,XY>(new XY(192,314), new XY(703,825)),
    new Tuple<XY,XY>(new XY(869,573), new XY(869,888)),
    new Tuple<XY,XY>(new XY(603,268), new XY(603,301)),
    new Tuple<XY,XY>(new XY(816,668), new XY(816,189)),
    new Tuple<XY,XY>(new XY(148,606), new XY(948,606)),
    new Tuple<XY,XY>(new XY(117,461), new XY(506,461)),
    new Tuple<XY,XY>(new XY(986,955), new XY(986,315)),
    new Tuple<XY,XY>(new XY(131,250), new XY(192,189)),
    new Tuple<XY,XY>(new XY(988,148), new XY(518,618)),
    new Tuple<XY,XY>(new XY(682,900), new XY(31,900)),
    new Tuple<XY,XY>(new XY(652,839), new XY(652,236)),
    new Tuple<XY,XY>(new XY(466,812), new XY(466,611)),
    new Tuple<XY,XY>(new XY(881,346), new XY(401,346)),
    new Tuple<XY,XY>(new XY(229,639), new XY(731,639)),
    new Tuple<XY,XY>(new XY(104,476), new XY(840,476)),
    new Tuple<XY,XY>(new XY(10,988), new XY(988,10)),
    new Tuple<XY,XY>(new XY(29,15), new XY(987,973)),
    new Tuple<XY,XY>(new XY(825,348), new XY(825,240)),
    new Tuple<XY,XY>(new XY(989,989), new XY(10,10)),
    new Tuple<XY,XY>(new XY(430,796), new XY(926,796)),
    new Tuple<XY,XY>(new XY(49,293), new XY(610,854)),
    new Tuple<XY,XY>(new XY(325,288), new XY(918,288)),
    new Tuple<XY,XY>(new XY(625,309), new XY(439,495)),
    new Tuple<XY,XY>(new XY(536,150), new XY(356,150)),
    new Tuple<XY,XY>(new XY(834,558), new XY(822,558)),
    new Tuple<XY,XY>(new XY(315,408), new XY(315,635)),
    new Tuple<XY,XY>(new XY(257,973), new XY(813,973)),
    new Tuple<XY,XY>(new XY(713,52), new XY(122,52)),
    new Tuple<XY,XY>(new XY(323,970), new XY(578,970)),
    new Tuple<XY,XY>(new XY(447,49), new XY(829,49)),
    new Tuple<XY,XY>(new XY(941,709), new XY(941,390)),
    new Tuple<XY,XY>(new XY(148,323), new XY(391,80)),
    new Tuple<XY,XY>(new XY(23,171), new XY(23,49)),
    new Tuple<XY,XY>(new XY(475,265), new XY(322,112)),
    new Tuple<XY,XY>(new XY(506,407), new XY(69,844)),
    new Tuple<XY,XY>(new XY(567,284), new XY(483,368)),
    new Tuple<XY,XY>(new XY(114,745), new XY(114,765)),
    new Tuple<XY,XY>(new XY(392,252), new XY(109,535)),
    new Tuple<XY,XY>(new XY(65,188), new XY(455,188)),
    new Tuple<XY,XY>(new XY(732,779), new XY(732,52)),
    new Tuple<XY,XY>(new XY(233,214), new XY(759,214)),
    new Tuple<XY,XY>(new XY(232,969), new XY(957,244)),
    new Tuple<XY,XY>(new XY(20,669), new XY(20,308)),
    new Tuple<XY,XY>(new XY(49,972), new XY(285,972)),
    new Tuple<XY,XY>(new XY(501,383), new XY(433,383)),
    new Tuple<XY,XY>(new XY(918,15), new XY(32,901)),
    new Tuple<XY,XY>(new XY(255,268), new XY(935,948)),
    new Tuple<XY,XY>(new XY(757,588), new XY(757,919)),
    new Tuple<XY,XY>(new XY(530,803), new XY(284,557)),
    new Tuple<XY,XY>(new XY(688,926), new XY(48,286)),
    new Tuple<XY,XY>(new XY(331,245), new XY(331,777)),
    new Tuple<XY,XY>(new XY(448,544), new XY(209,544)),
    new Tuple<XY,XY>(new XY(10,970), new XY(951,29)),
    new Tuple<XY,XY>(new XY(233,11), new XY(897,11)),
    new Tuple<XY,XY>(new XY(145,392), new XY(628,392)),
    new Tuple<XY,XY>(new XY(935,971), new XY(935,280)),
    new Tuple<XY,XY>(new XY(169,632), new XY(54,632)),
    new Tuple<XY,XY>(new XY(155,244), new XY(155,334)),
    new Tuple<XY,XY>(new XY(56,284), new XY(205,284)),
    new Tuple<XY,XY>(new XY(553,428), new XY(553,520)),
    new Tuple<XY,XY>(new XY(977,176), new XY(497,656)),
    new Tuple<XY,XY>(new XY(323,339), new XY(971,987)),
    new Tuple<XY,XY>(new XY(616,355), new XY(616,248)),
    new Tuple<XY,XY>(new XY(72,660), new XY(72,334)),
    new Tuple<XY,XY>(new XY(644,822), new XY(510,956)),
    new Tuple<XY,XY>(new XY(356,841), new XY(587,841)),
    new Tuple<XY,XY>(new XY(413,468), new XY(605,468)),
    new Tuple<XY,XY>(new XY(85,22), new XY(645,582)),
    new Tuple<XY,XY>(new XY(924,850), new XY(522,850)),
    new Tuple<XY,XY>(new XY(448,45), new XY(345,148)),
    new Tuple<XY,XY>(new XY(102,566), new XY(551,566)),
    new Tuple<XY,XY>(new XY(80,39), new XY(847,806)),
    new Tuple<XY,XY>(new XY(936,436), new XY(934,436)),
    new Tuple<XY,XY>(new XY(53,24), new XY(495,466)),
    new Tuple<XY,XY>(new XY(234,173), new XY(282,173)),
    new Tuple<XY,XY>(new XY(145,680), new XY(456,680)),
    new Tuple<XY,XY>(new XY(960,759), new XY(960,282)),
    new Tuple<XY,XY>(new XY(984,814), new XY(308,138)),
    new Tuple<XY,XY>(new XY(398,808), new XY(716,808)),
    new Tuple<XY,XY>(new XY(509,536), new XY(25,52)),
    new Tuple<XY,XY>(new XY(289,777), new XY(803,263)),
    new Tuple<XY,XY>(new XY(766,892), new XY(257,892)),
    new Tuple<XY,XY>(new XY(301,733), new XY(688,733)),
    new Tuple<XY,XY>(new XY(24,109), new XY(887,972)),
    new Tuple<XY,XY>(new XY(180,32), new XY(577,429)),
    new Tuple<XY,XY>(new XY(985,801), new XY(687,503)),
    new Tuple<XY,XY>(new XY(901,582), new XY(586,582)),
    new Tuple<XY,XY>(new XY(50,56), new XY(50,267)),
    new Tuple<XY,XY>(new XY(344,373), new XY(437,373)),
    new Tuple<XY,XY>(new XY(542,133), new XY(905,496)),
    new Tuple<XY,XY>(new XY(420,624), new XY(420,716)),
    new Tuple<XY,XY>(new XY(645,106), new XY(645,574)),
    new Tuple<XY,XY>(new XY(356,37), new XY(114,37)),
    new Tuple<XY,XY>(new XY(324,919), new XY(357,919)),
    new Tuple<XY,XY>(new XY(126,797), new XY(120,797)),
    new Tuple<XY,XY>(new XY(288,689), new XY(435,836)),
    new Tuple<XY,XY>(new XY(93,915), new XY(639,369)),
    new Tuple<XY,XY>(new XY(106,391), new XY(478,19)),
    new Tuple<XY,XY>(new XY(277,501), new XY(714,64)),
    new Tuple<XY,XY>(new XY(253,277), new XY(643,277)),
    new Tuple<XY,XY>(new XY(568,972), new XY(350,972)),
    new Tuple<XY,XY>(new XY(213,235), new XY(213,406)),
    new Tuple<XY,XY>(new XY(595,888), new XY(595,233)),
    new Tuple<XY,XY>(new XY(577,63), new XY(37,603)),
    new Tuple<XY,XY>(new XY(649,732), new XY(931,732)),
    new Tuple<XY,XY>(new XY(469,892), new XY(549,892)),
    new Tuple<XY,XY>(new XY(953,895), new XY(953,457)),
    new Tuple<XY,XY>(new XY(222,213), new XY(290,213)),
    new Tuple<XY,XY>(new XY(841,800), new XY(841,336)),
    new Tuple<XY,XY>(new XY(685,143), new XY(25,143)),
    new Tuple<XY,XY>(new XY(441,127), new XY(441,146)),
    new Tuple<XY,XY>(new XY(646,586), new XY(56,586)),
    new Tuple<XY,XY>(new XY(698,122), new XY(465,122)),
    new Tuple<XY,XY>(new XY(641,502), new XY(641,240)),
    new Tuple<XY,XY>(new XY(111,91), new XY(185,91)),
    new Tuple<XY,XY>(new XY(927,755), new XY(874,808)),
    new Tuple<XY,XY>(new XY(108,151), new XY(108,567)),
    new Tuple<XY,XY>(new XY(309,453), new XY(309,210)),
    new Tuple<XY,XY>(new XY(890,657), new XY(491,657)),
    new Tuple<XY,XY>(new XY(404,244), new XY(404,123)),
    new Tuple<XY,XY>(new XY(939,28), new XY(26,941)),
    new Tuple<XY,XY>(new XY(596,970), new XY(596,870)),
    new Tuple<XY,XY>(new XY(489,556), new XY(489,589)),
    new Tuple<XY,XY>(new XY(607,621), new XY(903,325)),
    new Tuple<XY,XY>(new XY(912,284), new XY(571,284)),
    new Tuple<XY,XY>(new XY(921,702), new XY(743,524)),
    new Tuple<XY,XY>(new XY(719,36), new XY(719,394)),
    new Tuple<XY,XY>(new XY(100,905), new XY(798,207)),
    new Tuple<XY,XY>(new XY(316,260), new XY(316,887)),
    new Tuple<XY,XY>(new XY(799,940), new XY(885,940)),
    new Tuple<XY,XY>(new XY(835,287), new XY(199,923)),
    new Tuple<XY,XY>(new XY(422,760), new XY(64,760)),
    new Tuple<XY,XY>(new XY(727,113), new XY(727,679)),
    new Tuple<XY,XY>(new XY(733,56), new XY(59,730)),
    new Tuple<XY,XY>(new XY(141,399), new XY(485,743)),
    new Tuple<XY,XY>(new XY(769,629), new XY(769,797)),
    new Tuple<XY,XY>(new XY(62,486), new XY(62,205)),
    new Tuple<XY,XY>(new XY(192,332), new XY(800,332)),
    new Tuple<XY,XY>(new XY(15,931), new XY(727,931)),
    new Tuple<XY,XY>(new XY(854,915), new XY(988,915)),
    new Tuple<XY,XY>(new XY(349,610), new XY(886,610)),
    new Tuple<XY,XY>(new XY(72,110), new XY(72,903)),
    new Tuple<XY,XY>(new XY(955,110), new XY(78,987)),
    new Tuple<XY,XY>(new XY(591,553), new XY(591,428)),
    new Tuple<XY,XY>(new XY(708,467), new XY(516,467)),
    new Tuple<XY,XY>(new XY(397,589), new XY(353,589)),
    new Tuple<XY,XY>(new XY(930,336), new XY(930,532)),
    new Tuple<XY,XY>(new XY(639,50), new XY(228,50)),
    new Tuple<XY,XY>(new XY(472,17), new XY(472,244)),
    new Tuple<XY,XY>(new XY(420,825), new XY(420,562)),
    new Tuple<XY,XY>(new XY(203,197), new XY(203,35)),
    new Tuple<XY,XY>(new XY(984,964), new XY(223,203)),
    new Tuple<XY,XY>(new XY(944,269), new XY(935,260)),
    new Tuple<XY,XY>(new XY(933,119), new XY(87,965)),
    new Tuple<XY,XY>(new XY(696,290), new XY(696,580)),
    new Tuple<XY,XY>(new XY(925,960), new XY(52,87)),
    new Tuple<XY,XY>(new XY(451,470), new XY(235,254)),
    new Tuple<XY,XY>(new XY(562,71), new XY(562,149)),
    new Tuple<XY,XY>(new XY(405,126), new XY(405,67)),
    new Tuple<XY,XY>(new XY(356,424), new XY(356,673)),
    new Tuple<XY,XY>(new XY(859,649), new XY(859,291)),
    new Tuple<XY,XY>(new XY(210,651), new XY(210,544)),
    new Tuple<XY,XY>(new XY(403,783), new XY(403,122)),
    new Tuple<XY,XY>(new XY(672,87), new XY(586,87)),
    new Tuple<XY,XY>(new XY(409,668), new XY(984,668)),
    new Tuple<XY,XY>(new XY(917,352), new XY(511,758)),
    new Tuple<XY,XY>(new XY(395,953), new XY(141,953)),
    new Tuple<XY,XY>(new XY(152,795), new XY(152,313)),
    new Tuple<XY,XY>(new XY(839,344), new XY(811,372)),
    new Tuple<XY,XY>(new XY(114,649), new XY(650,649)),
    new Tuple<XY,XY>(new XY(60,517), new XY(60,27)),
    new Tuple<XY,XY>(new XY(448,392), new XY(845,392)),
    new Tuple<XY,XY>(new XY(33,849), new XY(719,163)),
    new Tuple<XY,XY>(new XY(151,988), new XY(876,988)),
    new Tuple<XY,XY>(new XY(805,556), new XY(124,556)),
    new Tuple<XY,XY>(new XY(361,538), new XY(706,193)),
    new Tuple<XY,XY>(new XY(974,941), new XY(141,108)),
    new Tuple<XY,XY>(new XY(271,813), new XY(968,116)),
    new Tuple<XY,XY>(new XY(500,697), new XY(80,277)),
    new Tuple<XY,XY>(new XY(586,731), new XY(586,480)),
    new Tuple<XY,XY>(new XY(128,147), new XY(174,101)),
    new Tuple<XY,XY>(new XY(882,681), new XY(882,745)),
    new Tuple<XY,XY>(new XY(531,730), new XY(677,730)),
    new Tuple<XY,XY>(new XY(989,11), new XY(11,989)),
    new Tuple<XY,XY>(new XY(74,332), new XY(234,492)),
    new Tuple<XY,XY>(new XY(360,326), new XY(932,898)),
    new Tuple<XY,XY>(new XY(136,288), new XY(113,311)),
    new Tuple<XY,XY>(new XY(666,645), new XY(916,895)),
    new Tuple<XY,XY>(new XY(977,478), new XY(561,62)),
    new Tuple<XY,XY>(new XY(20,83), new XY(566,83)),
    new Tuple<XY,XY>(new XY(331,942), new XY(331,646)),
    new Tuple<XY,XY>(new XY(180,291), new XY(405,291)),
    new Tuple<XY,XY>(new XY(637,763), new XY(637,941)),
    new Tuple<XY,XY>(new XY(120,138), new XY(120,820)),
    new Tuple<XY,XY>(new XY(951,24), new XY(14,961)),
    new Tuple<XY,XY>(new XY(204,304), new XY(204,51)),
    new Tuple<XY,XY>(new XY(84,168), new XY(880,168)),
    new Tuple<XY,XY>(new XY(955,145), new XY(955,903)),
    new Tuple<XY,XY>(new XY(437,427), new XY(437,354)),
    new Tuple<XY,XY>(new XY(875,67), new XY(189,753)),
    new Tuple<XY,XY>(new XY(46,767), new XY(802,11)),
    new Tuple<XY,XY>(new XY(52,59), new XY(889,896)),
    new Tuple<XY,XY>(new XY(926,56), new XY(102,880)),
    new Tuple<XY,XY>(new XY(500,30), new XY(964,30)),
    new Tuple<XY,XY>(new XY(329,488), new XY(329,972)),
    new Tuple<XY,XY>(new XY(63,11), new XY(889,837)),
    new Tuple<XY,XY>(new XY(707,168), new XY(707,584)),
    new Tuple<XY,XY>(new XY(580,10), new XY(735,10)),
    new Tuple<XY,XY>(new XY(105,620), new XY(105,110)),
    new Tuple<XY,XY>(new XY(187,531), new XY(323,531)),
    new Tuple<XY,XY>(new XY(82,947), new XY(82,941)),
    new Tuple<XY,XY>(new XY(737,199), new XY(737,851)),
    new Tuple<XY,XY>(new XY(612,650), new XY(217,650)),
    new Tuple<XY,XY>(new XY(971,15), new XY(82,904)),
    new Tuple<XY,XY>(new XY(16,590), new XY(506,100)),
    new Tuple<XY,XY>(new XY(950,877), new XY(832,759)),
    new Tuple<XY,XY>(new XY(570,470), new XY(570,276)),
    new Tuple<XY,XY>(new XY(213,411), new XY(213,195)),
    new Tuple<XY,XY>(new XY(670,755), new XY(89,755)),
    new Tuple<XY,XY>(new XY(906,963), new XY(906,984)),
    new Tuple<XY,XY>(new XY(458,463), new XY(442,463)),
    new Tuple<XY,XY>(new XY(956,969), new XY(10,23)),
    new Tuple<XY,XY>(new XY(87,215), new XY(195,107)),
    new Tuple<XY,XY>(new XY(819,454), new XY(819,467)),
    new Tuple<XY,XY>(new XY(594,793), new XY(686,793)),
    new Tuple<XY,XY>(new XY(395,724), new XY(787,332)),
    new Tuple<XY,XY>(new XY(315,461), new XY(644,461)),
    new Tuple<XY,XY>(new XY(448,247), new XY(249,48)),
    new Tuple<XY,XY>(new XY(620,302), new XY(247,675)),
    new Tuple<XY,XY>(new XY(607,134), new XY(932,134)),
    new Tuple<XY,XY>(new XY(312,776), new XY(312,289)),
    new Tuple<XY,XY>(new XY(850,942), new XY(54,146)),
    new Tuple<XY,XY>(new XY(31,538), new XY(851,538)),
    new Tuple<XY,XY>(new XY(729,126), new XY(640,126)),
    new Tuple<XY,XY>(new XY(702,199), new XY(702,706)),
    new Tuple<XY,XY>(new XY(402,783), new XY(254,783)),
    new Tuple<XY,XY>(new XY(110,59), new XY(203,59)),
    new Tuple<XY,XY>(new XY(27,10), new XY(965,948)),
    new Tuple<XY,XY>(new XY(747,261), new XY(47,261)),
    new Tuple<XY,XY>(new XY(628,742), new XY(972,742)),
    new Tuple<XY,XY>(new XY(712,742), new XY(657,797)),
    new Tuple<XY,XY>(new XY(877,871), new XY(877,758)),
    new Tuple<XY,XY>(new XY(665,313), new XY(449,529)),
    new Tuple<XY,XY>(new XY(498,157), new XY(498,68)),
    new Tuple<XY,XY>(new XY(870,922), new XY(27,79)),
    new Tuple<XY,XY>(new XY(856,697), new XY(856,429)),
    new Tuple<XY,XY>(new XY(447,271), new XY(963,787)),
    new Tuple<XY,XY>(new XY(495,302), new XY(495,520)),
    new Tuple<XY,XY>(new XY(526,47), new XY(721,47)),
    new Tuple<XY,XY>(new XY(826,179), new XY(826,741)),
    new Tuple<XY,XY>(new XY(565,461), new XY(893,461)),
    new Tuple<XY,XY>(new XY(512,328), new XY(127,328)),
    new Tuple<XY,XY>(new XY(487,920), new XY(522,920)),
    new Tuple<XY,XY>(new XY(614,452), new XY(614,146)),
    new Tuple<XY,XY>(new XY(331,574), new XY(331,840)),
    new Tuple<XY,XY>(new XY(985,79), new XY(285,779)),
    new Tuple<XY,XY>(new XY(812,320), new XY(985,320)),
    new Tuple<XY,XY>(new XY(118,69), new XY(429,69)),
    new Tuple<XY,XY>(new XY(644,525), new XY(644,878)),
    new Tuple<XY,XY>(new XY(271,132), new XY(156,132)),
    new Tuple<XY,XY>(new XY(955,782), new XY(565,392)),
    new Tuple<XY,XY>(new XY(630,939), new XY(630,372)),
    new Tuple<XY,XY>(new XY(51,203), new XY(840,203)),
    new Tuple<XY,XY>(new XY(202,490), new XY(202,479)),
    new Tuple<XY,XY>(new XY(579,868), new XY(579,92)),
    new Tuple<XY,XY>(new XY(979,336), new XY(979,623)),
    new Tuple<XY,XY>(new XY(843,865), new XY(260,282)),
    new Tuple<XY,XY>(new XY(685,872), new XY(685,503)),
    new Tuple<XY,XY>(new XY(721,193), new XY(721,510)),
    new Tuple<XY,XY>(new XY(908,661), new XY(908,955)),
    new Tuple<XY,XY>(new XY(19,950), new XY(715,254)),
    new Tuple<XY,XY>(new XY(233,730), new XY(233,101)),
    new Tuple<XY,XY>(new XY(922,954), new XY(27,954)),
    new Tuple<XY,XY>(new XY(399,444), new XY(399,403)),
    new Tuple<XY,XY>(new XY(380,712), new XY(380,718)),
    new Tuple<XY,XY>(new XY(238,264), new XY(849,875)),
    new Tuple<XY,XY>(new XY(458,577), new XY(458,139)),
    new Tuple<XY,XY>(new XY(418,244), new XY(469,295)),
    new Tuple<XY,XY>(new XY(460,375), new XY(964,879)),
    new Tuple<XY,XY>(new XY(276,445), new XY(815,445)),
    new Tuple<XY,XY>(new XY(463,910), new XY(648,725)),
    new Tuple<XY,XY>(new XY(26,384), new XY(968,384)),
    new Tuple<XY,XY>(new XY(955,385), new XY(955,143)),
    new Tuple<XY,XY>(new XY(942,775), new XY(733,566)),
    new Tuple<XY,XY>(new XY(425,326), new XY(531,326)),
    new Tuple<XY,XY>(new XY(364,545), new XY(364,873)),
    new Tuple<XY,XY>(new XY(182,759), new XY(182,819)),
    new Tuple<XY,XY>(new XY(390,757), new XY(390,475)),
    new Tuple<XY,XY>(new XY(217,417), new XY(217,157)),
    new Tuple<XY,XY>(new XY(669,286), new XY(65,890)),
    new Tuple<XY,XY>(new XY(257,11), new XY(257,858)),
    new Tuple<XY,XY>(new XY(557,397), new XY(557,20)),
    new Tuple<XY,XY>(new XY(888,946), new XY(32,90)),
    new Tuple<XY,XY>(new XY(971,938), new XY(971,578)),
    new Tuple<XY,XY>(new XY(874,248), new XY(874,485)),
    new Tuple<XY,XY>(new XY(87,268), new XY(87,135)),
    new Tuple<XY,XY>(new XY(756,679), new XY(103,26)),
    new Tuple<XY,XY>(new XY(771,250), new XY(771,107)),
    new Tuple<XY,XY>(new XY(320,711), new XY(967,711)),
    new Tuple<XY,XY>(new XY(293,219), new XY(293,706)),
    new Tuple<XY,XY>(new XY(103,565), new XY(103,538)),
    new Tuple<XY,XY>(new XY(388,256), new XY(388,261)),
    new Tuple<XY,XY>(new XY(468,953), new XY(503,953)),
    new Tuple<XY,XY>(new XY(424,142), new XY(287,142)),
    new Tuple<XY,XY>(new XY(24,930), new XY(850,930)),
    new Tuple<XY,XY>(new XY(316,167), new XY(316,161)),
    new Tuple<XY,XY>(new XY(481,421), new XY(208,148)),
    new Tuple<XY,XY>(new XY(938,926), new XY(938,933)),
    new Tuple<XY,XY>(new XY(701,653), new XY(701,780)),
    new Tuple<XY,XY>(new XY(536,390), new XY(536,559)),
    new Tuple<XY,XY>(new XY(40,954), new XY(829,165)),
    new Tuple<XY,XY>(new XY(404,985), new XY(247,985)),
    new Tuple<XY,XY>(new XY(94,628), new XY(94,500)),
    new Tuple<XY,XY>(new XY(441,637), new XY(441,271)),
    new Tuple<XY,XY>(new XY(766,946), new XY(97,277)),
    new Tuple<XY,XY>(new XY(428,363), new XY(428,37)),
    new Tuple<XY,XY>(new XY(542,694), new XY(542,347)),
    new Tuple<XY,XY>(new XY(11,16), new XY(979,984)),
    new Tuple<XY,XY>(new XY(938,651), new XY(632,957)),
    new Tuple<XY,XY>(new XY(779,127), new XY(243,663)),
    new Tuple<XY,XY>(new XY(636,294), new XY(636,787)),
    new Tuple<XY,XY>(new XY(533,744), new XY(636,641)),
    new Tuple<XY,XY>(new XY(521,950), new XY(458,950)),
    new Tuple<XY,XY>(new XY(988,12), new XY(18,982)),
    new Tuple<XY,XY>(new XY(954,621), new XY(954,271)),
    new Tuple<XY,XY>(new XY(638,951), new XY(813,951)),
    new Tuple<XY,XY>(new XY(822,911), new XY(632,911)),
    new Tuple<XY,XY>(new XY(714,849), new XY(512,849)),
    new Tuple<XY,XY>(new XY(696,88), new XY(385,88)),
    new Tuple<XY,XY>(new XY(65,451), new XY(65,687)),
    new Tuple<XY,XY>(new XY(976,973), new XY(976,907)),
    new Tuple<XY,XY>(new XY(368,489), new XY(368,571)),
    new Tuple<XY,XY>(new XY(358,831), new XY(690,499)),
    new Tuple<XY,XY>(new XY(436,704), new XY(178,704)),
    new Tuple<XY,XY>(new XY(690,619), new XY(606,535)),
    new Tuple<XY,XY>(new XY(96,701), new XY(358,701)),
    new Tuple<XY,XY>(new XY(885,562), new XY(420,562)),
    new Tuple<XY,XY>(new XY(581,480), new XY(613,512)),
    new Tuple<XY,XY>(new XY(44,970), new XY(970,44)),
    new Tuple<XY,XY>(new XY(216,796), new XY(892,120)),
    new Tuple<XY,XY>(new XY(72,623), new XY(72,72)),
    new Tuple<XY,XY>(new XY(896,283), new XY(896,326)),
    new Tuple<XY,XY>(new XY(794,195), new XY(22,967)),
    new Tuple<XY,XY>(new XY(134,326), new XY(134,889)),
    new Tuple<XY,XY>(new XY(420,141), new XY(944,665)),
    new Tuple<XY,XY>(new XY(941,194), new XY(941,421)),
    new Tuple<XY,XY>(new XY(940,525), new XY(298,525)),
    new Tuple<XY,XY>(new XY(653,300), new XY(769,300)),
    new Tuple<XY,XY>(new XY(227,424), new XY(406,603)),
    new Tuple<XY,XY>(new XY(275,850), new XY(113,850)),
    new Tuple<XY,XY>(new XY(648,850), new XY(92,850)),
    new Tuple<XY,XY>(new XY(638,389), new XY(638,10)),
    new Tuple<XY,XY>(new XY(379,404), new XY(584,609)),
    new Tuple<XY,XY>(new XY(833,931), new XY(833,520)),
    new Tuple<XY,XY>(new XY(772,286), new XY(500,558)),
    new Tuple<XY,XY>(new XY(372,262), new XY(333,262)),
    new Tuple<XY,XY>(new XY(689,18), new XY(131,576)),
    new Tuple<XY,XY>(new XY(687,499), new XY(687,188)),
    new Tuple<XY,XY>(new XY(344,499), new XY(37,806)),
    new Tuple<XY,XY>(new XY(778,496), new XY(134,496)),
    new Tuple<XY,XY>(new XY(938,87), new XY(344,681)),
    new Tuple<XY,XY>(new XY(788,401), new XY(479,401)),
    new Tuple<XY,XY>(new XY(828,903), new XY(756,903)),
    new Tuple<XY,XY>(new XY(423,625), new XY(285,763)),
    new Tuple<XY,XY>(new XY(218,489), new XY(218,819)),
    new Tuple<XY,XY>(new XY(488,384), new XY(891,787)),
    new Tuple<XY,XY>(new XY(817,532), new XY(788,532)),
    new Tuple<XY,XY>(new XY(512,27), new XY(512,149)),
    new Tuple<XY,XY>(new XY(369,794), new XY(54,794)),
    new Tuple<XY,XY>(new XY(534,590), new XY(827,883)),
    new Tuple<XY,XY>(new XY(84,310), new XY(39,265)),
    new Tuple<XY,XY>(new XY(357,545), new XY(665,545)),
    new Tuple<XY,XY>(new XY(539,807), new XY(539,781)),
    new Tuple<XY,XY>(new XY(378,683), new XY(22,327)),
    new Tuple<XY,XY>(new XY(71,909), new XY(943,37)),
    new Tuple<XY,XY>(new XY(740,552), new XY(348,552)),
    new Tuple<XY,XY>(new XY(698,315), new XY(45,968)),
    new Tuple<XY,XY>(new XY(516,835), new XY(360,835)),
    new Tuple<XY,XY>(new XY(629,141), new XY(629,385)),
    new Tuple<XY,XY>(new XY(695,908), new XY(303,908)),
    new Tuple<XY,XY>(new XY(795,707), new XY(386,707)),
    new Tuple<XY,XY>(new XY(211,397), new XY(291,397)),
    new Tuple<XY,XY>(new XY(64,620), new XY(236,620)),
    new Tuple<XY,XY>(new XY(97,638), new XY(97,445)),
    new Tuple<XY,XY>(new XY(46,103), new XY(893,950)),
    new Tuple<XY,XY>(new XY(468,122), new XY(979,122)),
    new Tuple<XY,XY>(new XY(810,486), new XY(433,486)),
    new Tuple<XY,XY>(new XY(532,899), new XY(461,970)),
    new Tuple<XY,XY>(new XY(232,60), new XY(235,60)),
    new Tuple<XY,XY>(new XY(549,708), new XY(549,90)),
    new Tuple<XY,XY>(new XY(294,978), new XY(294,124)),
    new Tuple<XY,XY>(new XY(865,406), new XY(640,406)),
    new Tuple<XY,XY>(new XY(755,305), new XY(664,305)),
    new Tuple<XY,XY>(new XY(12,989), new XY(987,14)),
    new Tuple<XY,XY>(new XY(275,249), new XY(260,234)),
    new Tuple<XY,XY>(new XY(502,783), new XY(67,783)),
    new Tuple<XY,XY>(new XY(863,938), new XY(297,372)),
    new Tuple<XY,XY>(new XY(516,961), new XY(516,272)),
    new Tuple<XY,XY>(new XY(67,510), new XY(611,510)),
    new Tuple<XY,XY>(new XY(980,951), new XY(312,283)),
    new Tuple<XY,XY>(new XY(325,512), new XY(325,169)),
    new Tuple<XY,XY>(new XY(142,429), new XY(542,29)),
    new Tuple<XY,XY>(new XY(273,964), new XY(822,964)),
    new Tuple<XY,XY>(new XY(370,217), new XY(508,217)),
    new Tuple<XY,XY>(new XY(131,131), new XY(331,331)),
    new Tuple<XY,XY>(new XY(734,824), new XY(734,817)),
    new Tuple<XY,XY>(new XY(75,89), new XY(687,701)),
    new Tuple<XY,XY>(new XY(155,255), new XY(702,802)),
    new Tuple<XY,XY>(new XY(577,395), new XY(130,395)),
    new Tuple<XY,XY>(new XY(684,94), new XY(555,94)),
    new Tuple<XY,XY>(new XY(393,881), new XY(173,881)),
    new Tuple<XY,XY>(new XY(894,750), new XY(773,750)),
    new Tuple<XY,XY>(new XY(380,269), new XY(380,338)),
    new Tuple<XY,XY>(new XY(427,36), new XY(427,77)),
    new Tuple<XY,XY>(new XY(637,107), new XY(637,846)),
    new Tuple<XY,XY>(new XY(53,437), new XY(53,221)),
    new Tuple<XY,XY>(new XY(128,979), new XY(960,147)),
    new Tuple<XY,XY>(new XY(838,211), new XY(838,645)),
    new Tuple<XY,XY>(new XY(898,39), new XY(849,39)),
    new Tuple<XY,XY>(new XY(862,495), new XY(951,495)),
    new Tuple<XY,XY>(new XY(754,406), new XY(76,406)),
    new Tuple<XY,XY>(new XY(951,960), new XY(113,122)),
    new Tuple<XY,XY>(new XY(830,125), new XY(15,940)),
    new Tuple<XY,XY>(new XY(190,117), new XY(190,973)),
    new Tuple<XY,XY>(new XY(192,956), new XY(718,430)),
    new Tuple<XY,XY>(new XY(895,162), new XY(88,969)),
    new Tuple<XY,XY>(new XY(135,196), new XY(70,131)),
    new Tuple<XY,XY>(new XY(578,642), new XY(578,789)),
    new Tuple<XY,XY>(new XY(713,268), new XY(625,268)),
    new Tuple<XY,XY>(new XY(938,719), new XY(938,604)),
    new Tuple<XY,XY>(new XY(30,863), new XY(99,863)),
    new Tuple<XY,XY>(new XY(844,309), new XY(287,309)),
    new Tuple<XY,XY>(new XY(131,837), new XY(459,509)),
    new Tuple<XY,XY>(new XY(61,206), new XY(722,867)),
    new Tuple<XY,XY>(new XY(95,974), new XY(283,974)),
    new Tuple<XY,XY>(new XY(746,672), new XY(558,672)),
    new Tuple<XY,XY>(new XY(552,32), new XY(352,32)),
    new Tuple<XY,XY>(new XY(21,637), new XY(21,781)),
    new Tuple<XY,XY>(new XY(945,847), new XY(945,303))
};

//var simpleInput = input.Where(i => i.Item1.X == i.Item2.X || i.Item1.Y == i.Item2.Y).ToArray();

var grid = new int[1000,1000];

foreach (var item in input)
{
    var running = true;

    var x = item.Item1.X;
    var y = item.Item1.Y;
    
    while (running)
    {
        grid[x, y]++;
        
        if (item.Item1.X < item.Item2.X)
        {
            x++;
            if (x > item.Item2.X)
                running = false;
        }
        else if (item.Item1.X > item.Item2.X)
        {
            x--;
            if (x < item.Item2.X)
                running = false;
        }
        
        if (item.Item1.Y < item.Item2.Y)
        {
            y++;
            if (y > item.Item2.Y)
                running = false;
        }
        else if (item.Item1.Y > item.Item2.Y)
        {
            y--;
            if (y < item.Item2.Y)
                running = false;
        }
    }
}

// for (var y = 0; y < 10; y++)
// {
//     for (var x = 0; x < 10; x++)
//     {
//         if (grid[x,y] == default)
//             Console.Write(". ");
//         else
//             Console.Write(grid[x,y] + " ");
//     }
//     
//     Console.WriteLine("");
// }

var points = 0;

foreach (var item  in grid)
{
    if (item > 1)
        points++;
}

Console.WriteLine($"Two or more: {points}");