using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{

	class Sim_VAN_EX1_133 : SimTemplate //* 毁灭之刃 Perdition's Blade
	{
		//<b>Battlecry:</b> Deal 1 damage. <b>Combo:</b> Deal 2 instead.
		//<b>战吼：</b>造成1点伤害。<b>连击：</b>改为造成2点伤害。
        CardDB.Card w = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.VAN_EX1_133);

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            int dmg = (ownplay) ? p.getSpellDamageDamage(1) : p.getEnemySpellDamageDamage(1);
            if (p.cardsPlayedThisTurn >= 1) dmg = (ownplay) ? p.getSpellDamageDamage(2) : p.getEnemySpellDamageDamage(2);
            p.minionGetDamageOrHeal(target, dmg);
            p.equipWeapon(w, ownplay);
        }


        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_IF_AVAILABLE),
            };
        }
    }

    
}
