using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 萨满祭司 费用：5 攻击力：5 生命值：5
	//Carress, Cabaret Star
	//歌唱明星卡瑞斯
	//<b>Battlecry:</b> Draw 2 cards.Deal 2 damage to all enemy minions.
	//<b>战吼：</b>抽两张牌。对所有敌方随从造成2点伤害。
	class Sim_VAC_449t5 : SimTemplate
	{

        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            // 抽两张牌
            p.drawACard(CardDB.cardIDEnum.None, own.own);
            p.drawACard(CardDB.cardIDEnum.None, own.own);

            // 对所有敌方随从造成2点伤害
            p.allMinionOfASideGetDamage(!own.own, 2);
        }
    }
}
