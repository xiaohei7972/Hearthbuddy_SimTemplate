using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 巫妖王 费用：2 攻击力：2 生命值：2
	//Dreadhound Handler
	//恐惧猎犬训练师
	//[x]<b>Rush</b><b>Deathrattle:</b> Summon a 1/1Dreadhound with <b>Reborn</b>.
	//<b>突袭</b>。<b>亡语：</b>召唤一只1/1并具有<b>复生</b>的恐惧猎犬。
	class Sim_VAC_514 : SimTemplate
	{

        CardDB.Card dreadhound = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.VAC_514t); // 假设1/1恐惧猎犬的卡牌ID是 VAC_514t

        public override void onDeathrattle(Playfield p, Minion m)
        {
            int pos = m.zonepos;
            p.callKid(dreadhound, pos, m.own);
        }
    }
}
