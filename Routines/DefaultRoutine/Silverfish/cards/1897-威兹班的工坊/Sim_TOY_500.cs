using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 萨满祭司 费用：4
	//Baking Soda Volcano
	//苏打火山
	//<b>Lifesteal</b>. Deal $10 damage randomly split among all minions.<b>Overload:</b> (1)
	//<b>吸血</b>。造成$10点伤害，随机分配到所有随从身上。<b>过载：</b>（1）
	class Sim_TOY_500 : SimTemplate
	{
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            
            if (ownplay)
            {
                // 分配总共10点随机伤害到所有随从
                p.allMinionsGetRandomDamage(10);

                // 吸血效果：恢复等同于造成的伤害的生命值
                p.minionGetDamageOrHeal(ownplay ? p.ownHero : p.enemyHero, -10);

                p.ueberladung += 1;  // 过载1点法力水晶
            }
        }
    }
}
