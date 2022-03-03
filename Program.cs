using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teste_LP;
using static System.Console;

namespace Teste_LP
{
    public static class Program
    {
        public static void Main()
        {
            #region TextoA
            string TextoA = "vwv rhjs vqgvcq pjdvb gjpsmc jsm zhctgvl jwgbbs mccxbmj mbspg cdhsspgx twndc pmpr bzqvnxs" +
                " wnfwhcrp czj txvghq ltdtqrd plqnjsk rbsx ftc fwthpfb vdflfqs zvgbgb rxdrgkjp sbplvr tntr" +
                " fbbrmxw nkxbvf rznlm jdssqdds kwq vtlfdh zrtqk ndqnq lhbmhq ghkt vsr kqlxjmdn hlrrvg dtsm" +
                " hbkxjht whmfnw hwcxxj mrft xntwrhp zfh lbhchcdz fwqqqldj cjhdddn tkfscrmq jbdxmb rqj hsbm" +
                " rqhqz xzftrjg rqcprpcw phlhjcm hmvwqnps hdbjlj rgnq pxbbcfwj wnbkmkvr xqhn vcsbh grb xmbhxlml" +
                " gqtvjlsw plwcvdx tqgvq xcffkzm cmkfhshr zgbswzr pnbbxsht frhxmg csrcr brnfggrj wgphtk mhfz" +
                " tzlgfp xfpdfhpw pzq qsqjjn vzsw csch nzgbmln rzc bzh vptms xgldndlt rdctbpfp hkjbls rvvpg" +
                " jghvh dqv xxdkftl qgnrnlhk crwstts kctqjsl cdwcbph cxqxhq znjpdq brsbnk dxdlf tlvhvq rcms" +
                " lwd gtxdhxkl jvmrsxz fjg kztwskq ngszspnv twgffp ntvs xbxp svtx rhpndvh kmk qvm txmgknxk" +
                " dlpf wvnbn lgmnjgw msn nzwch wvkzzjfj xvwh wmslgqz fzx kfgzn gbmnnnx xrgtzxc jkprpc nwxlpbqr" +
                " pnskmbgn xslxdrr hmvnxfwd mvlznjbs lzd nkhvwpd jwlspvwn fbdc qccz ppwn dwfjfprh rgjhkb tvkc" +
                " pvlhvnn qvzhxdsv hxwsvt glcvbs crqsnlpp vhxxhk qmbzg nxwpfmlj mghxmtp qslnn rgbk dqrzs lvwwrk" +
                " dnnbqj krcbp rpcw bgpg rfqsp xxfcwq bwlc dnvrhhc gfkzcl qpvdsp cfb lmhcc grzj cqbkq gtjrzkqq" +
                " hmfcnjtd zhs rvzlch vtxk qmqr vql zpwxfmj rhpjs gcr qqmfxqv fpgp slfn bcqbwltn zbvjwc mqcwb" +
                " vtmfg zvrg xbxdrc dbcm nknlpfc stnkc hqkqrlqq vbfllt svkzqttr jrhhl kkqrz vlrnzbqn lpcpp jmjmnqwj" +
                " bnmnmrbh wrmvbr khqhpxhz cbwpgf wffjnk zrlslx nvjkj wdwz vgrk ztdnzg blrb tbq xzfhwn knwgqk fqzpbc" +
                " pddkbdz spdv tpkndf wjvb htjjnfg dcbkws dkhz phx hnqgg chq fqrdt vfvjvjhk nbvdzrn xgl bzddqxkp" +
                " kgqjfxsn nlmmslnb vsw tmwshk lrqbxdqb jlvf dzztm skxk htrh hvmscx vtf gtvhlcs cdsqqhnm ttfr" +
                " shcrwqkh fwvrqs qdppk jkvw hdcrmxz lklksspg kng rspr pgl rlpdjtd bnjzqgb fmrt qjpwsmcg sgfxxd" +
                " knpprkz vxp jzgtdtst tghhrf hbv hnzbfvs wzrbhdkt ncpj lfhlp fnhgkb splq lrrdz nflwl jvjdwsh qmdv" +
                " bdjck wkmk mwjtkdf szdbb zsjvxx sxkftwmg qdph mqf hvd rwnck zfmcmjdl mbxtgzhz tcxcf jck fsprt mzswtb" +
                " lppcbl vwrdkfbs zdmfr fgmkc jdx kfs kch jvsf fcnxx hmkzq gprl hclw zzkmm tzz chfpsxq zsnjvmv klsdcz" +
                " tzv lxws fmpc zfkzxk gzhwxlxk hzmrchx xrbv wvpnz jfhpql ntwqnchk wnbrptf gfptj wmqx hdpcgrf hzsq kwzjrb" +
                " gffqvwf jqqk brnkn stfdpfgc fclchmkb zgsjn qkwrxncc cfrzw nszzgp mxmgkxvg mvrwtm ftqrbpg npfqnvq hhw" +
                " pzgfkkl txf xmpbnp fxxm vjqckhkc zpn tqjckk whgszgvd ttxm gdbnszk hhjfz sqdkm vqzggb qcg sqfnqttc" +
                " crtlpf mlwqjxgt sffczr jgx tng jbgx vdxxxrvs fwm tcf nsjrmnp lpjppbb wksg clftm jjxlncpn tnrrmc pqls" +
                " zdcvth mbrwt hcrtb lxsxfqn zclnfzv gszffz xdtvpjhs bvgqqfg mlksdv txktscz bxphb cgp qtwtnwd mpm" +
                " wppgb vwm hssddc bdxxvtfn mkst qdhnr pfvbjx mxlxblj lzhcm ndzzrxdn wwhqdpqg zsqwl xgtrsvbj frwjqm" +
                " vwrpqgh rpmlxxlt bsj ptl dkvrsqw mdl fxz dxnhl xjb krs fjtccn pfdbs hsvqw pbzqvs fsbh pvrcjdc fjht" +
                " qwmj hxn cqzx qxkdqpj chzghzr lzf kks dqbrjbg vwzwl dtm rtghx zrqzjjv xdssrljz nxgsrkr hkv jtbblclw" +
                " qzzl qkvwf cxxc rfq wxhld cljqnm dldj cjldqqbl shtd gnhpjjhf rdkf wpfsp nqcqnb kxll bsgtc dzlrx dvnfs" +
                " xlwrfcwq hxd tqfxrbr svfnm dqjmmmp ltvw fjb xpxcg zkg jqqhctv zcshqzwn jtlg gmq rzhn cdzvdl gbpxd lmskl" +
                " gbxkk jch jxdqjc ktlpk vjwzjmn mfdtp dcv wchmbn rqjdgpv hhrc sxrdjgvf bsgqvvvv mrd szfpkrjv ncp mml kgcpg" +
                " nrthfqs hrhskq mbs kjqq btb wzjxcdb gjtx mfskzwd wfw zlqlndf xmq pktfltsk kkr kbf htczjl lkclqnrs lnvxmsk" +
                " shsdr xvdnk gkqfrpw hlnfvk sjzmnfx xhdlgp wmnc bbjcsnmh qxzttrzf vppzfv cxlvr rgs twpz lskqvwz ffp vtcsh" +
                " plgf btsgvh rgfgqfzp kwlr spgqpfkh snwtpwtr gbtdlfz cscvwnm bcfnbcx qmzwzq cfpwpm mrh xmktdqs mbpv zzmv" +
                " vvr cnhg pcz tqrsztnh hhrxq vfklm chpwb bwvpc pbxp fzjxmtns sjlkk ltqpph gmwwtb jbqrftv kqqbz npfbkj pct" +
                " glbqz lmzsv pprmv dsd tpmpk zpxwmsg mvvwmsbv jcl glwth jtg pczwpdqg knsxpsj bfcb fjtwz gznb nbhn wlj swgv" +
                " sszdlff xqshpc bdb rhsj rcz lqnwmztx nqqz pmz jchqs zcvmrckj gmxrcl vsvw vhxhlp zlhlfgh jrjzsmh zbnm" +
                " mbmwbflw kpfjlp zfrdfjkv ljs njc lvbgtsm zgfztg ksc zzrfnk fgm hsqgkhm qrmd zfq xwrhjp vqvsftk gxf vjftvvx mlc";
            #endregion
            #region TextoB
            string TextoB = "lqvxj prbf dgxv cgc wqvxbjs dbs msvtlbr frsm wbdqdg xhpjp jzfcchbs qjq zqtcjlkm slt tzbc" +
                " nsr wjhzxd rffqbkm dvfn gsvfgb blxxngsh zchhpqg dxmk zwngclz cgv tgxznzlg pvdnnx rnbj vwx xhrzg zdq bjqdhkps" +
                " dmpb gkk vfr whmxrbm pngfqc nlbd xgm cbpqw vvgxpv vzbbgx jlmtdcdk xvrmvkmt zbkvzjx bslb dtzwvk jsvk qqr llp" +
                " mxhjqck gkhmf xvqfqcjj ffvx zvmqpsm sxx vtbhc nhfg gcprb nxlctr dsbnb kwggfpw tqm fnvpsl vxdpzb ljcfrxg rzq mfq" +
                " hgrwcx pbktg nkslbdgc rslj xkrx hmdrsk nhf wwrqwtz lfqqjzw qdcvzvjc kdmmh wqnnkmcm qkwmdxlf mctc xkv nrbx lbdj" +
                " tdxgbb hpv gzvgndnb lhsvjxdd nvf mvlpsghr skvtfpw fjjxcp dvf dnjdzcrc bkv qsqplh rxcw tfnwhw lbttltk kphjcw sgmx" +
                " tdgjvqdb pmvhqzf rzhb fkxmsdw svqcpq hhx pprkm shh lfrstvcd rdkdqqq ddhgdcr tsk fmktwj trv ltwnhthz nml tsl kpzgksnh" +
                " ndz qtqglj dbwmdvh wgrvdklq csnlxvnj dcnzgs wwzr ngtc vppg fbvsdr vmx rkzcgw jjglmvb rpd rvdgxtnr xqgshj vclcmnh" +
                " smbhg xmjlklzl mcbz slkbsj xbnpc fzhjvm nmlwfjzp jpdbf qtgcdr vqb pbn pckrfls nbrntt vjvr xfznh rncvwwqq mhdmtcc" +
                " ffvnk slw grzxqblp ngfw gbmvvzvq qhrh trjbrzp cbzl rgspsq ljjtc rwfnm vkmzlgzc kcmjjd shv xxzv xnmgwfv lmrwzpw qpzlp" +
                " jzjj pmwqhz pbrfsrg nswcjr wmvczg tljp mwrggrf vss fmblgjv mpfzbnfc prjnll xvhqt gbzg tfhjnc mrpd zdm rhj gvx flwhzqjc" +
                " dkmk mpr vbf kqfl bhnw gfksm njmgtlm wqhvvfdl xhpxdp zdcrscjs gvqbj xjcf dqdmfcx dwcbkxw nslnvnb wjfmtngs fcrzzgw qhbr" +
                " gmkkcx pzsqlz csj pwsccx xhpsmr tsglsbh dfmqqscc jwnmzzdc xljfh hllng llswvqf xvjczjqh rwhznhqc mwhj jkz kxg blpwlzv" +
                " vxzlwz tzdtfs jpdn gqbwkh mqhjxv fxjllq zwnwtx flgp kdhvrrd mqd sslf xnwvvw thjplqgc xtlpxgg wwrpxqf rjtcchpx bjctn" +
                " sds jdb pwtdlzs tqx jrmn nwjhl slbwz vmrqk kdfkwp dwhbsphh tkwt nmqsm ppb slcmvfvp vtvf djw mjndf cpmn wmfpxmkz hnzmsr" +
                " fjkvvx thn hnvdt wtgpkv rgs qcdtjqqd jccdspqd rbkhmz hshmrpg xkjnccwt qrt fkfs bfdwt xsdnh bfdhjthj csk wksvnnf pbnj" +
                " mczhlf gpnqtfbd zwwpz zvn rthljf ltw stgsds gcjkqn rdgtf pmcwsnnr bdwmdh rgtcs lqdrhbpt zmprxdms nxzmdx slpgfx cpltlszl" +
                " zwrfsp pqrphcgm htwpkmn kwpntvvg nrfkdfx ksxz zfvx qzgppkd lfr mqwz tvcvgpqh rrbjf fnrvbnm qmsv zkhvcdmg kkfbpng smhqq" +
                " qtpqlkft slgbx wkvxwcm kgn mttrtqqs tjdtt rjrfsgzl xknsclbk mcbvdcnx rtgld wbbddlc gqmnpzzp gsxdnwqt prmkx ngj mpbxq zlzwhd" +
                " wgsnv rcp jsk ckblv tfmsnv djlqn btrj cvxgjqh kvw shk hrfcp ktthmtw zdt nlggcz gwxlzgfw xtkvx rhcxr dlnn zbbjqqh rjnvgs psvsmt" +
                " wskt bfsvwk txj brskv fbwcgm kbbpbf rmnpt tnvrmdk wnslrsfw lfbcg pxt mnwk dcpvcwq xbpgzfhn gpjp lsfbr sdgdxhq pjltpnvh vtjps" +
                " btqgwnx bkpjtxxm zgjfr cbttjszl zlgwfhsw klf zpgrx zbfxbrzr msm hrhfgfd bpmx xmnrh ncnhxnwk gtzn fdsbb xbrtsjv ltsxscx bvbmnnwp" +
                " gblnr ljcv sqnkt skrh svb jchd bqvsd ljx jgjdb fxlkmcvj tvglz qkjkdld bqk bsl vdhknm djjdb hppprkz bdfccz dqqp wsmw cvvn dbnqxf" +
                " dxzvtsc zqwqds nqdtvvpl mqcs bmsmq smthjb pplbtrw lpmddf hrsjfdzp hbpbb mgpnspj rwz pvgq psf cdvrl jmwkrt ljhnsql mddwc mcvhvk" +
                " rnfx xqxfblzh nxf dwhxs pgdt mtcfxhth jtnwbwb zkfnzflb fsvkvpn vsgwhvp xln mbhx vxn bwdwsmr pszmbbkc cxdhlsns fltrkh gmfdrhws" +
                " pnpczv lxzdlg hmllsbm cddnd jntxtzr qztdgfz npdgdlsf lkmg swsxjms njs vrddwhkh wwzp lcczhhm kdz jjl phbwrbm kkwww zrqqzq tpqb" +
                " bsdtmhb dtpdfhp mnmp gcv mtvlh cgdrcr gqvdj mxvsn hdmhn wqfr dljnvlzw phtzsmg hqdjc ttm jtpx vkwq zcs nfq fcjkqqc ntqfwvws" +
                " klckb cmwv tbrh zktqsjf vmxkz ttngcchg pmjnsvjf mhksp qhh gpjr ftnrfrkl xdbxxj wdlfbx phzwfrxr pldbsmh wlljvz gznxd lvw nhpf" +
                " jxv fhnhs nqczswv gpkxpzqs dztx ncfqfp xkj qpgshfv jsddbs pzfm bzfqmbx dmbkskh dllmlw zsh nzpdw kxslnqn pjlcmcxf jvcgmflg" +
                " vcc cxbcwz jlkhsvmx dvxndqf kcbllpw zqb rzfw fbwvmcd qns fmqx wqrtmw rzpss bcxg rdjkwd tfkfnj bnqqj cjzpz hxbvlst rtlpt" +
                " vrcwh qsh nkcrwhq stssffng hbt qrppcch vdkbrgc btr mmjwp fmstk rvjv gjnljlvv vbwxppd rcpql khnvl vmlpxtwb csd rtjh kjllq" +
                " xsnfw tmrc xfglnt spdxfn kmvxx qtf kpmkjl fxxrchdg tzwl jqwd qjx zmqqbd jmvk vjldrv pqspncnk scmz zjzt dplp hhpt rwldkr" +
                " mcbnbr kpx hxdz msdvx dbxcr hldpxf djxflkz hdhkfqh vsvzzft xwwxj pbqm ltfcl qnqd gslsk sdkzg ttxcwpc fkmlmqtk";
            #endregion

            Alfabet alfabet = new Alfabet();
            var BarCharacters = alfabet.bar;
            var FooCharacters = alfabet.foo;
            var CompleteAlfabet = alfabet.CompleteAlfabet;

            var TextoA_List = new List<string>();
            var TextoB_List = new List<string>();

            TextoA_List = TextoA.Split(' ').ToList();
            TextoB_List = TextoB.Split(' ').ToList();

            #region Preposições em Kinglon
            int counterPrepA, counterPrepB;
            counterPrepA = counterPrepB = 0;

            var resultPrepTextA = from T in TextoA_List
                                  let LastCharIndex_TextA = T.Substring(T.Length - 1, 1)
                                  where !(T.Contains("d")) &&
                                          T.Length <= 3 &&
                                          BarCharacters.Contains(LastCharIndex_TextA.ToString())
                                  select T;

            var resultPrepTextB = from T in TextoB_List
                                  let LastCharIndex_TextB = T.Substring(T.Length - 1, 1)
                                  where !(T.Contains("d")) &&
                                        T.Length <= 3 &&
                                        BarCharacters.Contains(LastCharIndex_TextB.ToString())
                                  select T;


            foreach (var item in resultPrepTextA)
                counterPrepA++;
            foreach (var item in resultPrepTextB)
                counterPrepB++;
            #endregion

            #region Verbos em Kinglon
            int counterVerbA, counterVerbA1, counterVerbB, counterVerbB1;
            counterVerbA = counterVerbA1 = counterVerbB = counterVerbB1 = 0;

            var resultVerbA = from T in TextoA_List
                              let lastLetterA = T.Substring(T.Length - 1, 1)
                              where T.Length >= 8 &&
                                    FooCharacters.Contains(lastLetterA.ToString())
                              select T;
            foreach (var item in resultVerbA)
                counterVerbA++;

            var resultVerbA1 = from T in resultVerbA
                               let firstLetterA = T.Substring(0, 1)
                               where BarCharacters.Contains(firstLetterA.ToString())
                               select T;
            foreach (var item in resultVerbA1)
                counterVerbA1++;

            var resultVerbB = from T in TextoB_List
                              let lastLetterB = T.Substring(T.Length - 1, 1)
                              where T.Length >= 8 &&
                                    FooCharacters.Contains(lastLetterB.ToString())
                              select T;
            var resultVerbB1 = from T in resultVerbB
                               let firstLetterB2 = T.Substring(0, 1)
                               where BarCharacters.Contains(firstLetterB2.ToString())
                               select T;

            foreach (var item in resultVerbB)
                counterVerbB++;
            foreach (var item in resultVerbB1)
                counterVerbB1++;
            #endregion

            #region TextoA Ordenado
            var TextoA_OrderedList = new List<string>();

            foreach (var item in TextoA_List)
            {
                if (!(TextoA_OrderedList.Contains(item)))
                    TextoA_OrderedList.Add(item);
            }
            
            var vocabulary = new Dictionary<string, string>();
            var orderedTextA = new StringBuilder("");
            var orderedLettersA = new StringBuilder("");
            foreach (var word in TextoA_OrderedList)
            {
                orderedLettersA.Clear();
                foreach (var letter in word)
                {
                    orderedLettersA.Append(CompleteAlfabet.IndexOf(letter.ToString()));
                }
                vocabulary.Add(word, orderedLettersA.ToString());
            }

            var orderedVocabulary = vocabulary.OrderBy(x => x.Value);
            foreach (var item in orderedVocabulary)
            {
                orderedTextA.Append(item.Key + " ");
            }
            orderedTextA.Remove(orderedTextA.Length - 1, 1);

            WriteLine(orderedTextA);
            #endregion
            #region TextoB Ordenado
            var TextoB_OrderedList = new List<string>();

            foreach (var item in TextoA_List)
            {
                if (!(TextoB_OrderedList.Contains(item)))
                    TextoB_OrderedList.Add(item);
            }

            var vocabularyB = new Dictionary<string, string>();
            var orderedTextB = new StringBuilder("");
            var orderedLettersB = new StringBuilder("");
            foreach (var word in TextoB_OrderedList)
            {
                orderedLettersB.Clear();
                foreach (var letter in word)
                {
                    orderedLettersB.Append(CompleteAlfabet.IndexOf(letter.ToString()));
                }
                vocabularyB.Add(word, orderedLettersB.ToString());
            }

            var orderedVocabularyB = vocabularyB.OrderBy(x => x.Value);
            foreach (var item in orderedVocabularyB)
            {
                orderedTextB.Append(item.Key + " ");
            }
            orderedTextB.Remove(orderedTextB.Length - 1, 1);
            WriteLine("--------------");
            WriteLine(orderedTextB);
            #endregion

            #region Numeros Bonitos
            int counterBeautyNumbersA, counterBeautyNumbersB;
            counterBeautyNumbersA = counterBeautyNumbersB = 0;
            foreach(var item in TextoA_List)
            {
                long weigth = 1;
                long number = 0;
                foreach (var letter in item)
                {
                    number = CompleteAlfabet.IndexOf(letter.ToString()) * weigth;
                    weigth *= 20;
                }
                if(number >= 440566 && number % 3 == 0)
                    counterBeautyNumbersA++;
            }
            
            foreach(var item in TextoB_List)
            {
                long weigth = 1;
                long number = 0;
                foreach(var letter in item)
                {
                    number = CompleteAlfabet.IndexOf(letter.ToString()) * weigth;
                    weigth *= 20;
                }
                if (number >= 440566 && number % 3 == 0)
                    counterBeautyNumbersB++;
            }

            #endregion

            WriteLine("------------------Bem  vindo------------------");

            WriteLine("Veja abaixo a quantidade de Preposições contidas nos textos A e B:");
            WriteLine("Total de Preposições TextoA: {0}", counterPrepA);
            WriteLine("Total de Preposições TextoB: {0}", counterPrepB);

            WriteLine("----------------------------------------------");

            WriteLine("\nVeja abaixo a quantidade de Verbos contidos nos textos A e B:");
            WriteLine("Total de Verbos TextoA: {0}", counterVerbA);
            WriteLine("Total de Verbos em 1° Pessoa TextoA: {0}", counterVerbA1);
            WriteLine("-------------------------");
            WriteLine("Total Verbos TextoB: {0}", counterVerbB);
            WriteLine("Total de Verbos em 1° Pessoa TextoB: {0}", counterVerbB1);

            WriteLine("----------------------------------------------");

            WriteLine("\nVeja abaixo a quantidade de Numeros Bonitos contidos nos textos A e B:");
            WriteLine("Total de Numeros Bonitos TextoA: {0}", counterBeautyNumbersA);
            WriteLine("Total de Numeros Bonitos TextoB: {0}", counterBeautyNumbersB);


            WriteLine("\nAperte qualquer letra para fechar");
            string txt = ReadLine();
        }
    }
}
