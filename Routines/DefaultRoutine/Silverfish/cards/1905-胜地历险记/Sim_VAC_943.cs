using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 术士 费用：3 攻击力：1 生命值：6
	//Sacrificial Imp
	//祭献小鬼
	//<b>Deathrattle:</b> If it's your turn, summon a 6/6Imp with <b>Taunt</b>.
	//<b>亡语：</b>如果此时是你的回合，召唤一个6/6并具有<b>嘲讽</b>的小鬼。
	class Sim_VAC_943 : SimTemplate
	{
        public override void onDeathrattle(Playfield p, Minion m)
        {
            if (p.isOwnTurn)
            {
                // 如果是你的回合，召唤一个6/6并具有嘲讽的小鬼
                p.callKid(CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.VAC_943t), m.zonepos, m.own);
            }
        }


    }
}
