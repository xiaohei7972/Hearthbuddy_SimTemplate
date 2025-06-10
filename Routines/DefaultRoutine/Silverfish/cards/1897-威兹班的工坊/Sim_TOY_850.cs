using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//地标 德鲁伊 费用：1
	//Magical Dollhouse
	//魔法妙妙屋
	//[x]Gain <b>Spell Damage +1</b>this turn only.
	//在本回合中获得<b>法术伤害+1</b>。
	class Sim_TOY_850 : SimTemplate
	{
        public override void useLocation(Playfield p, Minion triggerMinion, Minion target)
        {
            // 在本回合中增加法术伤害
            p.spellpower += 1;
            p.tempSpellPower += 1;
        }

        public override void onTurnEndsTrigger(Playfield p, Minion triggerEffectMinion, bool turnEndOfOwner)
        {
            // 检查是否是拥有者的回合结束
            if (turnEndOfOwner)
            {
                // 移除法术伤害加成
                p.spellpower -= p.tempSpellPower;
                p.tempSpellPower = 0;
            }
        }
    }
}
