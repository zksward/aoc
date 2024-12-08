﻿using System.Text.RegularExpressions;

namespace _2024;

public static partial class Day03
{
    [GeneratedRegex(@"do\(\)|don\'t\(\)|mul\((\d+),(\d+)\)")]
    private static partial Regex MulCommand { get; }
    public static void Run()
    {
        const string input = """
                             where()(< }when()mul(678,62)%mul(747,584)from()-select(59,725)mul(570,425)<~^:$where()!@}where()mul(542,816):don't()select()from()#(;!select()mul(541,668)mul(557,427)what()<#-why(952,537)*what()}mul(723,604)/^]'+;from()('-mul(227,146)'what()~*who():select()~from()do()mul(640,593)^$<*from()??>$mul(879,96),}?;(mul(465,50)>!~%'do()$'#'<**mul(781,977)-,?where();mul(154,168)>mul(532,770)(>#*what()/^}?mul(498,722)%^mul(710,295)from()@>mul(816,977)how(80,33)^$?what()how(),what()mul(987,59)'-mul(106,916) when();^(from()where()(what()mul(474,920)?%,mul(435,248)<mul(701,405)] {@mul(44,889)#>do(),:>$how();~^ from()mul(48,417),#,{mul(430,437)%[,@@mul(953,728)'mul(556,935)]]&select()when()!:/when()%mul(249,960)+;{select(),#mul(713,901)!?^when()%mul(910,594)&where()how(316,735)<mul(615,61)}-mul(539,208)what()@)?/#}(^mul(312,368)[%what(965,619)how()do():'}&;]>{mul(838,23)$mul(690,953)from();)who()}from()mul(803,624)when(){mul(280,406)mul(190,779)select()#+,[-mul(381,486)*&+['*mul(566,57)mul(91,816)>select()mul(578,725)%&!mul(173,595)*;'do()when()from()/mul(438,7)%mul(15,794)?when()from()}where()  who()-mul(103,235);mul(971,383)@do()$mul(250,84)<from()$;from(),what(359,353) )mul(525,511)$^{select() +}what()from()mul(159,625):where()!:###~><mul(823,941)what()mul(935,812)when()select()when():mul(736,661)how()mul(728,742)how()*+mul(627,380)?when(589,538)+mul(531,652)>when()where(306,50)select(454,21)@)*mul(419,450):{)mul(736,148))when()*{what()mul(831,562)>]/}who()'do()&who()*+,who(637,20)#/$mul(896,737)-#when()select()when(),:~$@mul(988,98) select()who(709,386);-*!where()~do()!^mul(870,729)what();@mul(749,333)&when()&#how() where()}who()#mul(935,153)[from()!mul(781,341)&){what()mul(833,819)/[~{/]@mul(184,985)^<%{;{mul(630,218){what()}#when()~$'mul(14,702)%>select()^[@mul(474,41)from(){$do()*select()#/how()mul(488,463:where()where(){]-,#-mul(407,949)what()select()where(364,988)^~#*who(){mul(999,525);;select()from()@'why()don't()<+:where()^from()-mul(558,527)@from()<what()&why()when()!from()mul(28,969)&where()};mul(101,807)~,~?mul(21,300)?mul(784,363)]?&{+^who())<mul(751,251)}where()when() mul(129,699)when()&[; do()#mul(593,157!  -how() {mul(336,273)$[mul(767*&:from()mul(350,145)]who(524,855)/#from()'/[!&mul(311,457)<select(259,997)}from()>$</+ do()from()!}where()~]:>!mul(838,414)where()-/mul(810,111)'<mul(973,153)~!mul(143,649)[}$don't()#:)$?*when()(select()mul(466,395)^#[<';&from(96,136)$(mul(371,173)$>how()who() :,where()mul(355,829what()'%^[mul(196,488)[mul(547,815)-how()$when()~ ~how()mul(24,761)!from()%]%?>mul(950,754)mul(649,683){>where()select()mul(771,439)mul(236,961)@what(),~what();^how()mul(791,10))why(),mul(278,737),why()<@~,]?from()do()+#/;} (/^when()mul(139,448)+%^(@ what())mul(122,226)select()[]select():mul(890>when()&what(508,897)select()>~{{{}mul(831,320)from())how()how()who()'mul(283,391);#@mul(310,864)&$-@!:where()mul(869,883)<$}@+<))mul(380,96)%?~ when()how()mul(629,878)#what()who()mul(888,359)$&*![&{~who()'mul(820,290)from()!{/(?,@^~mul(34,230);,don't()why(737,412):?mul(66,718)what(376,732)<mul(797,825)who()],<]why()mul(634,889)where()when()&!how(760,87)select():@what()mul(280,650)-! $ mul(509how()-#why()(>mul(315,501),:mul(706,831)when()mul(9,585)select()&from()mul(612,24)
                             )what()]'why()how(654,256)-mul(806,436)!/>~select():;'$from()mul(899,742)[%~mul(736,580)@where()who()why();how()>mul(23,836)when():when()}{}mul(715,293):mul(282,580)from()$?/*>mul(201,586);#;where()mul(118,230)who(){~!@!mul(88,537)#}-^/~mul(910,268)mul(976,63)^&{( :'mul(458,717)$$-how()^-]&+!mul(984,138)>;@where(752,136)mul(697,113)mul(124,665);!select()&how()what()mul(829,781)mul(380,512){!/<(]from()mul!@from():how()}<;(where()mul(206,188)>*how()%*when()mul(702,947)select(36,946)%}why()&+mul(129,741){/<)mul(16,381)how()what()*&{'}mul(192,91)who()$+&++mul(250,605)[[}select()-@,who(798,362)@don't()#how()} {?,who():mul(359,185)who(){ mul(467,606){why()-select()/*?mul(180,855)why()mul(134,121)!;'@~why(187,921)mul(437,28)mul(176,665)*?*!from()who()mul(432,913)[how()when()what()^/mul(277,854)$mul(311,503),%how()]/mul(290,640)where()<!mul(633,634)}[]mul(622,202)where()mul(524,996)!mul(432,456)%[what()what()@?<'who()mul(458,188)[^why()why()}^]mul(635,632)}where()from()^$how();}mul [mul(814,798)%mul(707,658);&+#,what() mul(493,278)what();[<#who()~mul(71,275)]/)>mul(945,575)@where(394,615)why()from(){where()/when()}mul(186,609)mul(105,239)&><)select()when():!mul(352,943)[ how()'why()#?how()who()]mul(148,156)~mul(797,298)#&-(++where(36,220)(~mul(141,332) mul(963,953)mul(79,791)~#);who())mul(465,458);#when(243,832)>#$*!?mul(977,49)where(808,80)$~]mul(84,878)where():(<< mul)/ :; mul(698,14)when()what()'>mul(455,546)%where()&@;when(491,752)$mul(185,720)?%]from()}how()%mul(402,280) #what()[[%' mul(612,36){when()mul(159,470)@*mul(238,734)}?from()why()' do()@who()mul(172,976)](;/what()<where()do()'[;from()who(),}where()select(542,70)mul(886,778)when()~who()mul(564,730)>-(how()$@@'mul(84,598)<@where()?what()<{?when()mul(162,924)mul(545,472)select(886,293){$when()from()//*mul(59,957)^*why(31,601)mul(608,367)'?@mul(915,987) +[mul(678,85) mul(501,729)-how()how()&select()($^$~do()!-what()-^;mul(682,420)when()mul(469,47)why(119,43)}~mul(699,30)?%>who()?{'mul(264,568)<}+!who()mul(579,479)mul(642,809)/,+>)<[mul(351,839){%(where()-}$mul(240,335)mul(475,338)^who()[{$@when();/mul(335,996)[+mul(954,892):when()what():who()mul(703,909))^,$'(what()do()&mul(675,270)%*];do()$<what()~# *where(){mul(700,774)+why()!mul(167,944)why()-{,?#*mul(263,222)when(937,759)how()[%do()when()~]*; how(),][mul(797,496)*# ,who()what()mul(417,548)+<@&who()mul(410,219)<how()-mul(946,326)how()mul(672,637),mul(928,490)who()why(217,124)from()mul(922,974)!^% mul(132+select()don't()who())<from()  &what()mul(357,21)who()({what()$mul(79,941)@>/select())#]#*mul(463,143)}how()when()!$]do()mul(832,164)-what()<what()//&#)what()mul(588,879)):?!;%mul(854,370)-#[[]why()mul(853,834)&!:!how()mul(83,715)who()select();#when();{mul(498,332):mul(681,273who()$<@# !why()mul(206,67)when());',%mul(341,939) ',mul(344,602)mul(803,721){{(mul(353,665)where()^)*^^(?(mul(19,951)&don't()where()mul(453,418)who():select(503,219)when()},mul(99,836);!mul(688,742)?when()^!how()why()mul(643,864)}%from()$mul(217,653)
                             <$*^mul(972,456)select()&(mul(408,506)!(#mul(627,283)why()@[{'%mul(352,904)where()?/,where()&%^$:mul(945,486)>$select(),%:  <mul(9,606)mul(306,642)%{( mul(120,260)-}~from()how()when()!/mul(98,87)[;why()[mul(947,277)(@mul(969,472)?[;what()mul(92,623)mul(5,792),what()#mul(180,460)where()when()({+!- +why(598,637)mul(659,178#}how()^what()@>mul(656,225)where()where()//mul(962,720)>-what()?!do()when()why()]how() $#mul(763,253)[+when()select())~when()mul(353,550){when()mul(664,37)mul(346,65)how()'%how()>select(310,753)mul(979,820)#[ mul(252,202)when(557,299)mul(665,232)when()((@&&%when()select()do()what()mul(730,599)[mul(163,61)why()/mul(235,484)^&don't(),^{~mul(476,543)why()mul(729,497)<why()@>select()],mul(344,943)#;mul(645,722)[)why(258,3)<select()mul(841,699)mul(658,372)how()]?{<select()-#mul(818,278)how()/)mul(530,148)*mul(604,712)why()[-~ )!]mul(425,760)[-where()!#+#what()who()don't()when()why()mul(400,735)+@!mul(523,543);*what():~^$,}*mul(286,589)^mul(875,453)&}^-:#<mul(205,529)>-who()}-mul(120,526)what()%?/}mul(892,273);&when()mulwhen():when()[[%)~ [-mul(374,778)why()/~'mul(56,465):>%&why()what()who(5,307)$'mul(59,457)what()#<{how(){~who()when()mul(79,949)how()mul(333,172)+@)!*{%:-mul(429,234){< +when(),(}}!mul(19,906)%<,@+from()from())mul(311,428)what()-/<,$!when()?mul(147,63) from()!why()^where()mul(579,972)}+don't()?how()[#$:*#mul(494,424)@&>where():mul(923,253)%who()<select()@>when(527,372)+]mul(926,810)why()from()mul(903,715)^mul(558,623)]^${ $%who()}when()do()-^what(501,771)#who()mulwhere()(-^%mul(536,670)%who()}why()'{mul(166,387)$:{+)<'?;+mul(723,383)%^^<%mul(17,614)#~*:why()#mul(523,552)?mul(603<#$#)>?'don't()';why();mul(488,276)where()what()>#:)@},mul(220,859)who()how()@<where()where();mulwhat()~}mul(900,800))!mul(247,569)where()how()+-*<[mul)[/mul(402,792){why()?,#@>!}mul(963,423)<*why()?from()}mul(407,10),@@how(457,318)$ %{?mul(449,618)what();mul(353,499)/]select()from()'<#?;who()mul(203,534)who(){(}/]<@-mul(382,560)',what(315,260)<${{from()what()who()mul(835,840)-+{from()<who()/,mul(41,350)^+@mul(12,298){~}mul(90,957)[:&]?#&'<mul(831,781);/~*'mul(122,529),when(687,987)mul(281@~mul(476,393)[%what()when()]:/(#mul(441,562)select()what()~mul(965,167)mul(244,812)'?select()mul(238,951)what()<;!mul(755,636):]don't() @{:]>(how()>(mul(16,437)^what()};)mul(877,407) ,select()why()'#~{(mul(850,948)mul(294,578)?{how()mul(588,142)' ,what()how()['mul(636,368)]/from(242,666):{]how()mul(890,543)&mul(608,298)<>when()mul(723,323)!why() where()/mul(865,602)^where()^mul(459,811)$'$&mul(927,406):mul(306,94)+[when()/#from()$select()mul(951,748)select())when()where()mul(498&/#]{{/select(),~mul(406,674)mul(217,369)+')/*how()%'mul(858,734)}:[where()<mul(922,634),why(19,798))+][mul(950,643)~$#-don't()+!{/!mul(31,380)([]how() -when(434,329)mul(528,682)mul(162$&:how()^<how())mul(265,640)}%[do()!*-mul(737,87)?^why()#'(select()*why()mul(512,635)!%mul(107,437)<*):]~who()$what()mul(906,266) ;!select()/{^mul(635,867)^<{^how()!where()where()#!/usr/bin/perl/?:mul(655,372)what(199,832);>%mul(814,477))%why(920,210)#>>*~who()select()mul(62,156)
                             ~&!?;{^mul(50,131)*+;[mul(721,655)~^)mul(554,894)>where()}from():,$mul(168,674)from()mul(801,339)what()mul(198,103)>^%!,@[mul(990,341)[<]~ %,~from()(mul(106,659)#'%(why()mul(534,944)select()',$mul(983,446)mul(589,257)[#'+~>#!mul(259,207);:select()#~~mul(570,191)mul(9,323)from()$mul(696]) how()}~$what()^mul(286,33)select(932,233)when()^~+  ~!mul(257,445)<~where()&~~from()?mul(659,273)@& where(981,521){><{/don't()mul(794,832)when()>when()mul(416,516)-what()#/do()why()/?>how()%;where()?,mul(900,44)select():'select()>mul(956,922)mul(534,313)+,$<mul(569,216)'mul(875,178+mul(576,106)&{<mul(457,835)from()what()mul(771,919)>{*/*mul(146what()?[why()}mul(846,806)#<select()!from()select()~ select()mul(993,127)>}%/where()-who():mul(640,359)mul(635,853)[*mul(603,687) :@(who(855,947)when(562,546)where()$-&mul(12,525)how()' ;mul(876,521)<>mul(798,388)>select()?{-,#who()mul(308,935)+when()where())mul(139,62):}}%mul(425,786)from()%/from()%mul(275,112)+mul(913,858)>'/}from()'(from()who()mul(924,718)-what()~*who()from()mul(974,670)^}:* @mul(323,427)-from()$]$<:+)mul(173,489)select()':+#%why()mul(513,137)!how()where()]mul(90,721)!why()]from(){;)from()mul(615,731)@^;why()mul(38,151)}>from()&  ]mul(904,102)+#mul(503,138)~)!([where()%mul(920,823);mul(584,684)?select(27,630)>what()]from()/mul(389,580)]^how()who()<%?mul(351,754)^{;%+)mul(693,528)$what()+?^don't();when(581,539),mul(581,172)who()!(mul(491,647)'where()?#who()'mul(550,759)mul(687,686)mul(849,285)when(613,863)do();~!&why()mul(122,69)(what()['mul(167,600)~how()$from()why()mul(174,781)}mul(821,889)'%how()select())from(939,434)[#where()mul(688,766)~how() select()<mul(79,304,<from()%mul(976,541)#mul(482,640)/^what(127,388),[{^how()$)mul(992,710)mul(687,9)&who(390,246)-@!%',,mul(728,710)how()why(68,923),who()#what()(where()when()mul(624,337)}select()<how()where()?!*mulwhere()how()why()mul(376,802)!#from(252,903)mul(60,496):#@where(363,376)>#^$%mul(572,90)where()@mul(170,232)when():' ,?do()#[&#;#^who()who()mul(599,515) ,!-how()'{^mul(751,829);where()why()&{?when()mul(751,40)?'what(),how()select()mulwho()when()'~}mul(712,196)when()>+;])where()mul(367,204)why()]why()(who()?;mul(56,507)}mul(845,878)<,>%)%>;&%mul(856,426)}#[{why()from()#who()~>mul(330,878)+where()when()?@?mul(783,827)/&>,why()who()-when()mul(447,463)!#~} [ *from()mul(990,245)>mul(19,581),from()}?&$[-mul(84,285)?^[!how()mul(703,674)/{**,!mul(833,486)%select()~what();&)[}where()mul(742,827),mul(605,535)-mulwho()from(793,741)when();}]who()#+~mul(100,3)}:;,from()mul(159,606)where()($what()}mul(134,409)[when(359,121))!why()when();mul(933,229)from(){>%#:$[-}mul(954,530)&-#}'*mul(614,803)where(): /'where()why()/mul(465,61)~do() ')why(560,602)[#mul(994,604)[how())when()(mul(284,925) -mul(271,788)%(~{^*where()who()mul(612,425)^%,mul(910,745)/(how()^((what():how()mul(732,779)mul(698<don't()mul(82,175)mul(386,509)<from();mul(454,768)#^%when()when()&&mul(941,963)what()>select()who()~%& ,mul(919,612)select()'select()when()~from()'mul(244,550)mul(361,26)@!>:mul(73,855)[;{'^>when()'+mul(948,339){&'&%#select()@why()mul(118,943) [how()({'?mul(639,13)
                             >-where()+/mul(612,127)-%#]+select()mul(71,341&~[when()(what()(&#{mul(613,682)**from()(>,!mul(822,212)from()%{select()(,;when()don't()!select()select()>select()*(mul(105,577):mul(765,221) &select(803,323)what()@-%}~mul(130,279)who(92,379):{%?what()+mul(114,722)+&&~from()what(),!?mul(969,103)> why();]@when()*]mul(391,680)-{select(460,460)&mul(513,976)>mul(212,86):[<mul(746,688)why(){mul(140,329)+(!^!&~do()&-,select()-;?#mul(327,421)}@-select(119,85)?}!why(447,976) mul(20,560)[mulhow()/%what()do():when()where();-$mul(690,257)[who()~!?<who()from():*mul(728,463)?-!,$<#when(635,309)mul(569,992)*select()mul(348,231)when()what(401,132)mul(734,962)what()-+,]&select()[<,mul(819,797)&',from(),;}(&mul(378,635)^!mul(692,702)?!:?(($how()mul(359,20)](what()[what()(-@mul(865,749)?;{[)where()from()mul$why()$where()/mul(707,669)%mul(9,881)why()mul(795,416)[mul(683,990)<~mul(801,670)where()when(),who()[+mul(993,621):from()when()]{,%how()when()mul(386,519)[)select()mul+)!]mul(152,672)<{+$mul(402,280)!-[/^$@who()mul(812,36{do()$mul(262,617)~where()-select()mul(797,218)^where();?mul(421,349)select()/[mul(841,580)how()what()what()how()#who()mul(797,115)mul(484,450)(mul(304,175)@+from()when()-#>@mul(771,766)what()~;+]where()what()(mul(600,442)?<#who()how()'who(740,254):(mul(196,517)/(don't()<%@what()[mul(320,909):who()((when()/^>mul(263,979)*&where()!why()$mul(484,668)<mul(17,432)}))mul(168,60where()}??$%mul(367,488)when()how()+[when()[;':mul(992,908)::when()]what()what():}don't() mul(72,331)+}what()*when()when()$/@mul(379,950)?what(786,109)~mul(255,952)~<where()/:{mul(532,854)^}(%&!'why()mul(539,11)(mul(292,42)?<~!!where()$<&mul(899,950),+why()how()how()do()!'$from(357,398)how()'>mul(724,359)]~!where()what();@mul(820,923)mul(636,398)?who()~from()mul(85,799)who()-%)why()($mul(615,634)who()%^how()%don't()why(124,8)?/<mul(258,695)&?+[;>^^{mul(600,813){select()<'from()!mul(611,346)mul(513,901),%who()^>*$don't()}@?@@why(872,343)+$mul(382,928)]%/&how()who()^select()select()mul(142,954) !+/how();?)!mul(978,138):(^select()<mul(329,540)}mul(597,980)select()^'$+when()^-mul(183,354)({!why()what() select()mul(983,243)<<select()-$from()from()+who()*mul(680,168);select()who()who();'~where()&mul(952,244)}[where()>>who()~where())mul(679,110)from()what()/@*<;how()mul(75,702)why()mul(367,513)~<$select()/[!^@[mul(868,828)@%mul(387,548)+]mul(774,392)where()&{}when()how()how(155,120)mul(569$,who(572,565)'#$mul(248,341)<<select()how()()/^mul(17,516)}+>who()?how()how()from(),,mul(972,116)+-%]-{-]/]mul(360,448),where()how()where()*$what()mul(441 )$select()mul(200,486))@;+[}!how()mul(5,767)how()+~why()-*&@mul(622,833)*where())mul(594,662)*>?where()!mul(598,524)mul(540:;$from()*where()%#+select()who()mul(588,233)*%why()select()?]what()<~mul(896]how()how()who(812,810)$$<<][mul(158,463)#>mul(304,924)from()select(466,292)select()mul(165,790)}?)]mul(350,950):$why()%+@^$what()/don't()<when()^)>'where()-:>mul(991,496)^>*[+from()mul(857,475)[)/-/<&don't(),)&$why(502,570)*mul(325,595<#who()mul(155,892)*{?why(23,519)#*$mul(194,882)<mul(279,687)how()@what()select())@$mul(236,621)how()[]*),&mul(320,242)from(){}!%when()!:-mul(630,655)/mul(146,899)!why()select(88,257) >mul(66,512){)mul(50,987)#who()where()how()select()+/mul(282,223)>*what()mul(644,695)[- ^]why(){mul(837,295)when():~+who()[?!select()mul(576,262)select()from()who()^&!&<mul(693,274) from()!what()mul(842,707)mul(645?#>select()%don't()++why()select()when()?,mul(535,959)what()<&&+*~ mul(289,483)when()mul(409,29){+mul(478,216[mul(455,288)
                             mul(485,849)%'&/} #why()mul(337,670)}&when(292,584)mul(291,636)$<,}mul(873,787)mul(583,597)from()%-{-(+!do()]?mul(508,735)where()+<[*,[^#mul(356,730) why()^what()@?where(558,563)!mul(254,728)mul(573,97)'when(){[!mul(847,358)>+-%[mul(445,707)~<+< *&who(192,588)/mul(339,368)why()?>how())*&when() mul(807,43)don't()$@%who();&(how()mul(719,162)#{(from(),;mul:~-where()%who()how(84,44),mul(970,95)where()(/]how():mul(223[;'?why()!/how()@@who()mul(507,673))^mul(977,524)from()select()^}{#)when()*mul(454,303)%select()*@,mul(563,289)*}who()<}<;why()&mul(673,375)^where()~mul(637,689)'*^who()?don't()who()where()<mul(729,329),?+mul(452,183)where();mul(412,329)select()&{^select()mul(304,748/-<~{$'$mul(250,311)^[!*@don't()-]%when()who()mul(275,612)mul(808,359)%:?how()'/$what()mul(125,6)>mul(347,707)[#mul(714,896)]mul(249,387)mul(991,762)from()when()where()how(553,916)-mul(116,473)& {who()mul(934,426)#)}from()mul(305,521)why(583,561)-;<}/how()mulwhat()<@&mul(667,932)%select()%mul(196,687))select()*do()from()/what()select()}mul(141,484)+]from()!'^how()who()[$mul(493,253):)&<mul(106,339)[#}[mul(527,610)/@&,#)/;who())mul(945,633)#who()!&,when(),]mul(699,592)*%mul(533,983)#:where()who()>$;[<]mul(663,997) {#@~:#-!mul(869,651)?*@/<#--do()mul(584,519)%select()what()who()-(!@how()don't()<,[!!;where()<^)mul(670,564);$what(),}mul(584,531)-(*mul(727,546)$:how(410,917)select()mul(447,208)'who()( ')&mul(476,15)how()where()^what()mul(332,458)what()?^where()how()how() {&how()mul(265,666)+(-~$mul(341,155)!,where()[mul(302,949);]select()-mul(459,712)-,+{$$+why()(from()mul(764,395)what()]!:do()$where()select():(when()when()where()mul(504,781)/'[why(65,459)where()**(select()%mul(215,820)(how()#{from()@why()do())$+?(*mul(59,437)!why()when()$)%)(when()mul(496,71) ]mul(265,963)/}mul(26,629)why()@]?-where()mul(918,981)#{@mul(179,990)when()%how()# ,mul(762,324)?from()%from(613,182)from(983,106)$!+mul(403,875)/>when(695,810))}when()@mul(992,141)*^who()when()what() do()how()why())[{[]&<mul(758,998)<!)#//'how()mul(966,404)* when()select()mul(772,998)'}&;;when()when(647,664)[;mul(357,688)(:mul(936,619)-'!)]from()why()what()[*mul(35,397)select()@@' mul(690,152)#where()mul(918,315)*'~];{%#mul(705,251),($;'mul(229,687)mul(12,423);# ;who()#('mul(409,16)mul(734,661)@[}*;{]*mul(642,531)(mul(897,68)}*[%-what()>why()when()mul(156,843)!;}/do()/<$mul(707,716)*why()'(mul(534,614),'((>mul(89,31)[-what(943,12)]from()-$mul(663,578)!^>mul(726,923)what():; ;$don't() mul(660,32)when()'what()^-]mul(684,845)@+#>#^~/^%mul(385,586)%what()mul(800,106)<mul(390,554)}mul(93,903)from()?;$mul(334,112)#what(549,926)-[ (mul(822,67)^'+%how(922,819) %^mul(535,921)mul(585,568)/:don't()mul(996,381);[mul(750,438)who()$;why()^?%[do()mul(837,207)@,select();^-$don't()why()why()>#why()mul(960,402)<,&{%what()]select()mul(289,89)%){>?+//mul(23,303)what()select(708,763)where()%how()><select()mul(542,492)how()when(976,435)select()#>%mul(224,519)+  ]mul(152,297)]mul(49,650)why()<)%where()mul(783,630)#
                             """;

        const string example = "xmul(2,4)&mul[3,7]!^don't()_mul(5,5)+mul(32,64](mul(11,8)undo()?mul(8,5))";

        var exampleMatches = MulCommand.Matches(example);
        var matches = MulCommand.Matches(input);

        Console.WriteLine("Example:\n");
        ExecuteParts(exampleMatches);
        Console.WriteLine("\nProblem:\n");
        ExecuteParts(matches);
        return;

        void ExecuteParts(MatchCollection matchCollection)
        {
            var result = 0;

            foreach (Match match in matchCollection)
            {
                if (match.ValueSpan.StartsWith("mul"))
                {
                    var a = int.Parse(match.Groups[1].ValueSpan);
                    var b = int.Parse(match.Groups[2].ValueSpan);
                    result += a * b;
                }
            }

            Console.WriteLine($"Part 1: {result}");

            var result2 = 0;
            var enabled = true;

            foreach (Match match in matchCollection)
            {
                if (enabled && match.ValueSpan.StartsWith("don't"))
                {
                    enabled = false;
                    continue;
                }
                if (!enabled && match.ValueSpan.StartsWith("do("))
                {
                    enabled = true;
                    continue;
                }
                if (enabled && match.ValueSpan.StartsWith("mul"))
                {
                    var a = int.Parse(match.Groups[1].ValueSpan);
                    var b = int.Parse(match.Groups[2].ValueSpan);
                    result2 += a * b;
                }
            }

            Console.WriteLine($"Part 2: {result2}");
        }
    }
}