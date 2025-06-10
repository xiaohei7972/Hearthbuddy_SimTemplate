
using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_RLK_018 : SimTemplate //* 凋零打击 Plague Strike
                                    //对一个随从造成3点伤害。如果该随从死亡，召唤一个2/2并具有&lt;b&gt;突袭&lt;/b&gt;的僵尸。
                                    //Deal 3 damage toa minion. If that kills it,summon a 2/2 Zombiewith &lt;b&gt;Rush&lt;/b&gt;.
    {
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            int dmg = (ownplay) ? p.getSpellDamageDamage(3) : p.getEnemySpellDamageDamage(3);
            p.minionGetDamageOrHeal(target, dmg);
			if(target.Hp <= dmg)
				p.drawACard(CardDB.cardIDEnum.RLK_018t, ownplay);	// 2-2 突袭狂暴僵尸
		}


        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
                // new PlayReq(CardDB.ErrorType2.REQ_ENEMY_TARGET),
            };
        }
    }


}
        