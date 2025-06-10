using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DRG_025 : SimTemplate //*海盗之锚 Ancharrr
	{

        CardDB.Card card = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.DRG_025);
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.equipWeapon(card, ownplay);
        }

        public override void onHeroattack(Playfield p, Minion own, Minion target)
        {
            p.drawACard(CardDB.cardIDEnum.CFM_637, own.own);
            p.evaluatePenality -= p.mana * 2;
        }
    }
}