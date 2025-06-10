using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_CFM_667 : SimTemplate //* 爆破小队 Bomb Squad
//[x]<b>Battlecry:</b> Deal 5 damageto an enemy minion.<b>Deathrattle:</b> Deal 5 damageto your hero.
//<b>战吼：</b>对一个敌方随从造成5点伤害。<b>亡语：</b>对你的英雄造成5点伤害。 
	{
		

        public override void getBattlecryEffect(Playfield p, Minion m, Minion target, int choice)
        {
            if (target != null) p.minionGetDamageOrHeal(target, 5);
        }

        public override void onDeathrattle(Playfield p, Minion m)
        {
            p.minionGetDamageOrHeal(m.own ? p.ownHero : p.enemyHero, 5);
        }

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_ENEMY_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_IF_AVAILABLE),
            };
        }
	}
}