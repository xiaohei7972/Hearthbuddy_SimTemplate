using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_VAN_HERO_02bp : SimTemplate //* 图腾召唤 Totemic Call
	{
		//<b>Hero Power</b>Summon a random Totem.
		//<b>英雄技能</b>随机召唤一个图腾。
		CardDB.Card searing = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.CS2_050);
        CardDB.Card healing = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.NEW1_009);
        CardDB.Card wrathofair = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.CS2_052);
        CardDB.Card stoneclaw = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.CS2_051);

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            int pos = (ownplay) ? p.ownMinions.Count : p.enemyMinions.Count;
            CardDB.Card kid;
            int otherTotems = 0;
            bool wrath = false;
            foreach (Minion m in (ownplay) ? p.ownMinions : p.enemyMinions)
            {
                switch (m.name)
                {
                    case CardDB.cardNameEN.searingtotem: otherTotems++; continue;
                    case CardDB.cardNameEN.stoneclawtotem: otherTotems++; continue;
                    case CardDB.cardNameEN.healingtotem: otherTotems++; continue;
                    case CardDB.cardNameEN.wrathofairtotem: wrath = true; continue;
                }
            }
            if (p.isLethalCheck)
            {
                if (otherTotems == 3 && !wrath) kid = wrathofair;
                else kid = healing;
            }
            else
            {
                if (!wrath) kid = wrathofair;
                else kid = searing;

                if (p.ownHeroHasDirectLethal()) kid = stoneclaw;
            }
            p.callKid(kid, pos, ownplay, false);
		}



        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_ENTIRE_ENTOURAGE_NOT_IN_PLAY),
                new PlayReq(CardDB.ErrorType2.REQ_NUM_MINION_SLOTS, 1),
            };
        }
	}
}