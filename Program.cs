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
            #region Comentarios
            /*
                -- Teste de Klingon
                Arqueólogos encontraram um pergaminho com os seguintes textos:

                TextoA e TextoB:
                Esses pergaminhos estão no antigo e misterioso idioma Klingon.
                Após muitos anos de estudo, os linguistas já conhecem algumas características desse idioma.

                Primeiramente, as letras Klingon são classificadas em dois grupos: as letras s, l, f, w e k são chamadas "letras tipo foo",
                enquanto que as demais são conhecidas como "letras tipo bar".

                Os linguistas descobriram que as preposições em Klingon são as palavras de 3 letras que terminam numa letra tipo bar,
                mas onde não ocorre a letra d. Portanto, é fácil ver que existem 63 preposições no Texto A.

                1) E no Texto B, quantas preposições existem?
                
            
                -- Verbos em Klingon
                Um outro fato interessante descoberto pelos linguistas é que, no Klingon,
                os verbos sempre são palavras de 8 ou mais letras que terminam numa letra tipo foo.
                Além disso, se um verbo começa com uma letra tipo bar, o verbo está em primeira pessoa.

                Assim, lendo o Texto A, é possível identificar 26 verbos no texto, dos quais 23 estão em primeira pessoa.
                
                2) Já no Texto B, quantos são os verbos?
                2.1) E quantos verbos do Texto B estão em primeira pessoa?
                
                -- Lista de vocabulário em Klingon
                Um professor universitário utilizará os textos A e B para ensinar o Klingon aos alunos.
                Para ajudar os alunos a compreender o texto, esse professor precisa criar uma lista de vocabulário para cada texto,
                isto é, uma lista ordenada (e sem repetições) das palavras que aparecem em cada um dos textos.
                
                Essas listas devem estar ordenadas e não podem conter repetições de palavras.
                No Klingon, assim como no nosso alfabeto, as palavras são ordenadas lexicograficamente, mas o problema é que no Klingon,
                a ordem das letras no alfabeto é diferente da nossa. O alfabeto Klingon, em ordem, é: 
                kbwrqdnfxjmlvhtcgzps. 

                Assim, ao fazer essas listas, o professor deve respeitar a ordem alfabética Klingon.

                O professor preparou a lista de vocabulário para o Texto A:
                TextoA_Ordenado;

                3) Como seria a lista de vocabulário do Texto B?
                
            
                -- Mas como os Klingon escrevem números?
                Bem, no Klingon, as palavras também são números dados em base 20, onde cada letra é um dígito,
                e os dígitos são ordenados do menos significativo para o mais significativo (o inverso do nosso sistema).
                Ou seja, a primeira posição é a unidade, a segunda posição vale 20, a terceira vale 400, e assim por diante.
                Os valores das letras são dados pela ordem em que elas aparecem no alfabeto Klingon (que é diferente da nossa ordem, como vimos acima).
                Ou seja, a primeira letra do alfabeto Klingon representa o dígito 0, a segunda representa o dígito 1, e assim por diante.

                Por exemplo, a palavra vwv tem o valor numérico de 4852.

                **OBS: os números nesse problema podem ser grandes, então se você está usando um tipo de dados de tamanho limitado,
                *      tenha cuidado com possíveis overflows.

                
                Os Klingons consideram um número bonito se ele satisfaz essas duas propriedades:
                - é maior ou igual a 440566
                - é divisível por 3

                Ao consideramos o Texto A como uma lista de números (isto é, interpretando cada palavra como um número usando a convenção explicada acima),
                notamos que existem 126 números bonitos distintos.
                
                4) E no Texto B, quantos números bonitos distintos existem?
                
             ------------------------------------------------------------------------------------------------

                Letras Klingon
                Letras tipo foo: s, l, f, w, k

                demais letras são tipo bar
                1) preposições em Klingon são as palavras de 3 letras que terminam numa letra tipo bar, mas
                onde NÃO ocorre a letra D.

                2) os verbos em Klingon são palavras de 8 ou mais letras, e terminam numa letra tipo foo.
                Caso comece com letra tipo Bar, está em 1° pessoa.

                Ordem do alfabeto Klingon:
                k, b, w, r, q, d, n, f, x, j, m, l, v, h, t, c, g, z, p, s
                (kbwrqdnfxjmlvhtcgzps)              
            */
            #endregion
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
                              let lastLetterA = T.Substring(T.Length -1, 1)
                              where T.Length >= 8 &&
                                    FooCharacters.Contains(lastLetterA.ToString())
                              select T;
            foreach (var item in resultVerbA)
                counterVerbA++;

            var resultVerbA1 = from T in resultVerbA
                               let firstLetterA = T.Substring(0, 1)
                               where BarCharacters.Contains(firstLetterA.ToString())
                               select T;
            foreach(var item in resultVerbA1)
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

            WriteLine("----------------------------");


            WriteLine("Total de Preposições TextoA: {0}", counterPrepA);
            WriteLine("Total de Preposições TextoB: {0}", counterPrepB);
            WriteLine("----------------------------------------------");

            WriteLine("Total de Verbos TextoA: {0}", counterVerbA);
            WriteLine("Total de Verbos em 1° Pessoa TextoA: {0}", counterVerbA1);
            WriteLine("-------------------------");
            WriteLine("Total Verbos TextoB: {0}", counterVerbB);
            WriteLine("Total de Verbos em 1° Pessoa TextoB: {0}", counterVerbB1);

            WriteLine("----------------------------------------------");

            WriteLine("\nAperte qualquer letra para fechar");
            string txt = ReadLine();
        }
    }
}
