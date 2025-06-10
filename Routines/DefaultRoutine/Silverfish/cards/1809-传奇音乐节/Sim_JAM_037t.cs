using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 中立 费用：0
	//Molten Pick of ROCK
	//熔火拨片
	//[x]At the end of turn, explodefor @ damage! <i>(Or spend allyour Mana to give this to theopponent with +2 damage.)</i>
	//在回合结束时爆炸，你的英雄受到@点伤害！<i>（或者消耗你的所有法力值，将本牌的伤害+2并交给你的对手。）</i>
	class Sim_JAM_037t : SimTemplate
	{
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            // 只是防止BUG，防止脚本打出这张牌。
			p.minionGetDamageOrHeal(p.ownHero, 100);
        }		
		
	}
}
