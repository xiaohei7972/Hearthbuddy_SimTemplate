using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 萨满祭司 费用：8 攻击力：8 生命值：8
	//Murloc Growfin
	//水宝宝鱼人
	//[x]<b>Gigantic</b><b>Battlecry:</b> Summon aTinyfin with <b>Rush</b> and statsequal to this minion's.
	//<b>大型</b><b>战吼：</b>召唤一个属性值等同于本随从并具有<b>突袭</b>的鱼人宝宝。
	class Sim_MIS_307t1 : SimTemplate
	{

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            // 召唤属性值等同于本随从的鱼人宝宝
            CardDB.Card tinyfinCard = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.MIS_307t); // 假设鱼人宝宝的卡牌ID是EX1_506a
            int position = ownplay ? p.ownMinions.Count : p.enemyMinions.Count; // 计算放置随从的位置
            p.callKid(tinyfinCard, position, ownplay);

            // 获取最后一个召唤的随从
            Minion tinyfin;
            if (ownplay)
            {
                tinyfin = p.ownMinions[p.ownMinions.Count - 1]; // 获取己方场上最后一个召唤的随从
            }
            else
            {
                tinyfin = p.enemyMinions[p.enemyMinions.Count - 1]; // 获取敌方场上最后一个召唤的随从
            }

            if (tinyfin != null && target != null)
            {
                // 复制水宝宝鱼人的属性
                tinyfin.Angr = target.Angr;
                tinyfin.Hp = target.Hp;
                tinyfin.maxHp = target.maxHp;

                // 赋予鱼人宝宝突袭
                tinyfin.rush = 1; // 突袭的实现通常通过设置charge属性
                tinyfin.Ready = true;  // 让突袭随从可以立即攻击
            }
        }
    }
}
