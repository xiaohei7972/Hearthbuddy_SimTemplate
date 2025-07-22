using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 术士 费用：10
	//Table Flip
	//掀桌子
	//Deal $3 damage to all enemy minions.Costs (1) less for each other card in your hand.
	//对所有敌方随从造成$3点伤害。你每有一张其他手牌，本牌的法力值消耗便减少（1）点。
	class Sim_TOY_883 : SimTemplate
	{
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            // 对所有敌方随从造成3点伤害
            p.allMinionOfASideGetDamage(false, 3);
        }
    }
}
