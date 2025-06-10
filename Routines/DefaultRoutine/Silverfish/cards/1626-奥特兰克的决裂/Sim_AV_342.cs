using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_AV_342 : SimTemplate //* 舍己为人 protecttheinnocent
	{
		//召唤一个5/5并具有<b>嘲讽</b>的防御者。在本回合中，如果你的英雄受到治疗，再召唤一个。
        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.AV_342t);

        
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            int pos = p.ownMinions.Count;
            p.callKid(kid, pos, ownplay);           
        }

        public override void onACharGotHealed(Playfield p, Minion triggerEffectMinion, int charsGotHealed)
        {
            int pos_ = p.ownMinions.Count;
            if (triggerEffectMinion.isHero && charsGotHealed > 0)
            {
                p.callKid(kid, pos_, true);
            }
        }
	}
}
