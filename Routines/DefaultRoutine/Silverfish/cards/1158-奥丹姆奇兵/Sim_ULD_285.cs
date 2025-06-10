using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_ULD_285 : SimTemplate //* 钩镰弯刀 Hooked Scimitar
	{
        //[x]<b>Combo:</b> Gain +2 Attack.
        //<b>连击：</b>获得+2攻击力。
        CardDB.Card w = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.ULD_285);
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.equipWeapon(w, ownplay);
            if (p.cardsPlayedThisTurn >= 1)
            {
                p.evaluatePenality -= 5;
                p.ownWeapon.Angr += 2;
                p.ownHero.Angr += 2;
            }         
        }
    }
}