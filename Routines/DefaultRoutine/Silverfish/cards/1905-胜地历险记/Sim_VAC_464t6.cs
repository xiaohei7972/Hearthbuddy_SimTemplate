using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 中立 费用：5 攻击力：8 生命值：8
	//Bubba
	//布巴
	//[x]<b>Battlecry</b>: Summon six1/1 Bloodhounds with<b>Rush</b> to attack anenemy minion.
	//<b>战吼：</b>召唤六只1/1并具有<b>突袭</b>的血猎犬并使其攻击一个敌方随从。
	class Sim_VAC_464t6 : SimTemplate
	{

        CardDB.Card bloodhound = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.GILA_400t); // 假设血猎犬的卡牌ID是 GILA_400t

        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            if (target != null)
            {
                int availableSlots = Math.Min(6, 7 - p.ownMinions.Count); // 计算场上可用位置，最多6个

                for (int i = 0; i < availableSlots; i++)
                {
                    int pos = own.own ? p.ownMinions.Count : p.enemyMinions.Count;
                    p.callKid(bloodhound, pos, own.own);

                    // 查找刚刚召唤的血猎犬
                    Minion summonedBloodhound = own.own ? p.ownMinions[p.ownMinions.Count - 1] : p.enemyMinions[p.enemyMinions.Count - 1];

                    summonedBloodhound.rush = 1; // 赋予突袭
                    p.minionAttacksMinion(summonedBloodhound, target); // 血猎犬攻击目标敌方随从
                }
            }
        }

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),  // 需要选择一个目标
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),    // 目标必须是随从
                new PlayReq(CardDB.ErrorType2.REQ_ENEMY_TARGET)    // 目标必须是敌方随从
            };
        }
    }
}
