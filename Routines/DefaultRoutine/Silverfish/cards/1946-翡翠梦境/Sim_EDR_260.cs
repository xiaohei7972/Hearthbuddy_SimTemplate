using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    //随从 中立 费用：4 攻击力：4 生命值：5
    //Illusory Greenwing
    //幻影绿翼龙
    //[x]<b>Taunt</b>. <b>Deathrattle:</b>Shuffle two 4/5 Dragons with<b>Taunt</b> into your deck. They're___<b>Summoned When Drawn</b>.
    //<b>嘲讽</b>。<b>亡语：</b>将两张<b>抽到时召唤</b>的4/5并具有<b>嘲讽</b>的龙洗入你的牌库。
    class Sim_EDR_260 : SimTemplate
    {
        public override void onDeathrattle(Playfield p, Minion m)
        {
            //获取幻影id
            CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDb.cardIDEnum.EDR_260t);
            //添加两张幻影到牌库
            for (int i = 1; i <= 2; i++)
            {
                p.AddToDeck(kid);
            }
        }

    }
}
