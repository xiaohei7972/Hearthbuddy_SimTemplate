using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_VAN_NEW1_040 : SimTemplate //* 霍格 Hogger
	{
		//At the end of your turn, summon a 2/2 Gnoll with_<b>Taunt</b>.
		//在你的回合结束时，召唤一个2/2并具有<b>嘲讽</b>的豺狼人。
        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.NEW1_040t);//gnoll
//    ruft am ende eures zuges einen gnoll (2/2) mit spott/ herbei.

        public override void onTurnEndsTrigger(Playfield p, Minion triggerEffectMinion, bool turnEndOfOwner)
        {
            if (triggerEffectMinion.own == turnEndOfOwner)
            {
                int posi = triggerEffectMinion.zonepos;

                p.callKid(kid, posi, triggerEffectMinion.own);
            }
        }

	}
}