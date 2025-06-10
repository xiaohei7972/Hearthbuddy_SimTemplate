using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 萨满祭司 费用：7 攻击力：7 生命值：7
	//Skarr, the Catastrophe
	//灾变飓风斯卡尔
	//[x]<b>Battlecry:</b> Deal @ damageto all enemies <i>(improved byeach turn in a row you've_played an Elemental)</i>.
	//<b>战吼：</b>对所有敌人造成@点伤害<i>（每有一个你使用过元素牌的连续的回合，伤害都会提升）</i>。
	class Sim_WW_026 : SimTemplate
	{
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            int damage = Hrtprozis.Instance.ownConsecutiveElementalTurns;    
            foreach (Minion enemy in p.enemyMinions)
           {
                p.minionGetDamageOrHeal(enemy, damage + 1);
           }
        }

		
	}
}
