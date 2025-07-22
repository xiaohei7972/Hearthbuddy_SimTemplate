using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_UNG_065t : SimTemplate //* 瑟拉金之种 Sherazin, Seed
//[x]<b>Dormant</b>When you play 4 cardsin a turn, revivethis minion.
//<b>休眠</b>在一回合中使用四张牌可唤醒该随从。 
	{
		

        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.UNG_065); 

        public override void onCardIsGoingToBePlayed(Playfield p, Handmanager.Handcard hc, bool wasOwnCard, Minion triggerEffectMinion)
        {
            triggerEffectMinion.Angr++;
            triggerEffectMinion.cantAttack = true;
            if (triggerEffectMinion.Angr > 3) p.minionTransform(triggerEffectMinion, kid);
        }

        public override void onTurnEndsTrigger(Playfield p, Minion triggerEffectMinion, bool turnEndOfOwner)
        {
            if (triggerEffectMinion.own == turnEndOfOwner)
            {
                triggerEffectMinion.Angr = 0;
            }
        }
    }
}