
using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_NX2_018 : SimTemplate //* 腐烂通灵师 Rotting Necromancer
                                    //&lt;b&gt;战吼：&lt;/b&gt;&lt;b&gt;探底&lt;/b&gt;。如果选中的是亡灵牌，对敌方英雄造成5点伤害。
                                    //&lt;b&gt;Battlecry:&lt;/b&gt; &lt;b&gt;Dredge.&lt;/b&gt; If it's an Undead, deal 5 damage to the enemy hero.
    {
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            if (target != null) p.minionGetDamageOrHeal(target, 5);
		}
    }


}
        