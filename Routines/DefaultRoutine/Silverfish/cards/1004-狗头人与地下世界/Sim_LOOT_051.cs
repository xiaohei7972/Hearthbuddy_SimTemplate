using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_LOOT_051 : SimTemplate //* 小型法术玉石 Lesser Jasper Spellstone
	{
        //Deal $2 damage to a minion. @<i>(Gain 3 Armor to upgrade.)</i>
        //对一个随从造成$2点伤害。@<i>（获得3点护甲值后升级。）</i>
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            int dmg = p.getSpellDamageDamage(2);
        }



        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
            };
        }
	}
}
