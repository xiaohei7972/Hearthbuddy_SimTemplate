using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 牧师 费用：3 攻击力：3 生命值：2
	//Sea Shill
	//海滩导购
	//<b>Battlecry</b>: The next card you play from a non-Rogue class costs (2) less.
	//<b>战吼：</b>你使用的下一张非潜行者的职业牌法力值消耗减少（2）点。
	class Sim_VAC_332 : SimTemplate
	{
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            if (own.own)
            {
            }
        }
    }
}
