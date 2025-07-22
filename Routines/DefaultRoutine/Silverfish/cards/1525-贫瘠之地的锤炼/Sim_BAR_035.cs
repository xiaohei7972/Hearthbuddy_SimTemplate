using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BAR_035 : SimTemplate //* 科卡尔驯犬者 Kolkar Pack Runner
	{
		//[x]After you cast a spell,summon a 1/1 Hyenawith <b>Rush</b>.
		//在你施放一个法术后，召唤一只1/1并具有<b>突袭</b>的土狼。
		public override void onCardIsGoingToBePlayed(Playfield p, Handmanager.Handcard hc, bool wasOwnCard, Minion triggerEffectMinion)
        {
            if (triggerEffectMinion.own == wasOwnCard && hc.card.type == CardDB.cardtype.SPELL)
            {
                int pos = (wasOwnCard) ? p.ownMinions.Count : p.enemyMinions.Count;
                p.callKid(CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.BAR_035t), pos, wasOwnCard);
            }
        }
		
	}
}
