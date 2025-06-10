using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 猎人 费用：6
	//Furious Fowls
	//猛禽狂怒
	//Choose an enemy. Summon two 3/2 Birds with <b>Immune</b> while attacking to attack it.
	//选择一个敌人。召唤两只3/2并具有攻击时<b>免疫</b>的小鸟，攻击选中的敌人。
	class Sim_VAC_410 : SimTemplate
	{

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            if (target != null)
            {
                // 召唤两只3/2的小鸟
                for (int i = 0; i < 2; i++)
                {
                    int pos = ownplay ? p.ownMinions.Count : p.enemyMinions.Count;
                    p.callKid(CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.VAC_410t), pos, ownplay, false);

                    // 获取最后召唤的随从
                    Minion bird = ownplay ? p.ownMinions[p.ownMinions.Count - 1] : p.enemyMinions[p.enemyMinions.Count - 1];

                    // 设置小鸟的属性，攻击时免疫
                    bird.Angr = 3;
                    bird.Hp = 2;
                    bird.immuneWhileAttacking = true;

                    // 让小鸟立即攻击选中的敌人
                    p.minionAttacksMinion(bird, target);
                }
            }
        }
    }
}
