using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 猎人 费用：4
	//R.C. Rampage
	//遥控狂潮
	//Summon six 1/1 Hounds. Any that can't fit give the others +1/+1.
	//召唤六只1/1的猎犬。每有一只放不下的猎犬，使其余猎犬获得+1/+1。
	class Sim_TOY_354 : SimTemplate
	{

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            int houndsToSummon = 6;  // 需要召唤的猎犬数量
            int availableSpace = ownplay ? 7 - p.ownMinions.Count : 7 - p.enemyMinions.Count;  // 检查场上空位
            int houndsSummoned = Math.Min(houndsToSummon, availableSpace);  // 实际能够召唤的猎犬数量
            int buffAmount = houndsToSummon - houndsSummoned;  // 每有一只放不下的猎犬，增加的buff数量

            // 召唤猎犬
            for (int i = 0; i < houndsSummoned; i++)
            {
                p.callKid(CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.EX1_538t), p.ownMinions.Count, ownplay);
            }

            // 给场上的猎犬增加+1/+1
            if (buffAmount > 0)
            {
                foreach (Minion m in (ownplay ? p.ownMinions : p.enemyMinions))
                {
                    if (m.nameCN == CardDB.cardNameCN.猎犬)  // 确保只给猎犬加buff
                    {
                        p.minionGetBuffed(m, buffAmount, buffAmount);
                    }
                }
            }
        }
    }
}
