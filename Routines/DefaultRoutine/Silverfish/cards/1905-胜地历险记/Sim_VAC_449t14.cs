using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 萨满祭司 费用：5 攻击力：5 生命值：5
	//Carress, Cabaret Star
	//歌唱明星卡瑞斯
	//<b>Battlecry:</b> Deal 2 damageto all enemy minions.<b>Freeze</b> three randomenemy minions.
	//<b>战吼：</b>对所有敌方随从造成2点伤害。随机<b>冻结</b>三个敌方随从。
	class Sim_VAC_449t14 : SimTemplate
	{

        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            // 对所有敌方随从造成2点伤害
            p.allMinionOfASideGetDamage(!own.own, 2);
        }
    }
}
