using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 萨满祭司 费用：1 攻击力：1 生命值：1
	//Shudderblock
	//沙德木刻
	//[x]<b>Mini</b><b>Battlecry:</b> Your next <b>Battlecry</b>triggers 3 times, but can't_damage the enemy hero.
	//<b>微型</b><b>战吼：</b>你的下一个<b>战吼</b>会触发3次，但无法伤害敌方英雄。
	class Sim_TOY_501t : SimTemplate
	{
        public override void getBattlecryEffect(Playfield p, Minion ownMinion, Minion target, int choice)
        {
            if (ownMinion.own)
            {
                // 设置玩家下一个战吼效果触发三次的标志
                p.nextBattlecryTriggers = 3;
            }
        }
    }
}
