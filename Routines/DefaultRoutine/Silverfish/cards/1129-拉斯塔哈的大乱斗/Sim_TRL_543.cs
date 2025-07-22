using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_TRL_543 : SimTemplate //* 血爪 Bloodclaw
                                    //<b>Battlecry:</b> Deal 5 damage to your hero.
                                    //<b>战吼：</b>对你的英雄造成5点伤害。 
    {


        CardDB.Card weapon = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.TRL_543);

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.equipWeapon(weapon, ownplay);
        }

        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
			p.minionGetDamageOrHeal(own.own ? p.ownHero : p.enemyHero, 5);
        }
    }
}