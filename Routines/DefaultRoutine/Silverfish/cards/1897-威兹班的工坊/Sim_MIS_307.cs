using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    //随从 萨满祭司 费用：1 攻击力：1 生命值：1
    //Murloc Growfin
    //水宝宝鱼人
    //[x]<b>Gigantify</b><b>Battlecry:</b> Summon aTinyfin with <b>Rush</b> and statsequal to this minion's.
    //<b>扩大</b><b>战吼：</b>召唤一个属性值等同于本随从并具有<b>突袭</b>的鱼人宝宝。
    class Sim_MIS_307 : SimTemplate
    {
        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.MIS_307t);
        public override void onCardPlay(Playfield p, Minion own, Minion target, int choice)
        {
            // 扩大效果：抽一张衍生物牌
            CardDB.cardIDEnum gigantifyCardID = CardDB.cardIDEnum.MIS_307t1; // 假设衍生物牌的 ID 是 MIS_307t
            p.drawACard(gigantifyCardID, own.own, true);
        }
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            // 召唤属性值等同于本随从的鱼人宝宝
            int position = own.own ? p.ownMinions.Count : p.enemyMinions.Count; // 计算放置随从的位置
            if (position < 7)
            {
                p.callKid(kid, own.zonepos, own.own);

                // 获取最后一个召唤的随从
                Minion tinyfin;
                if (own.own)
                {
                    tinyfin = p.ownMinions[Math.Max(own.zonepos - 1, 0)]; // 获取己方场上最后一个召唤的随从
                }
                else
                {
                    tinyfin = p.enemyMinions[Math.Max(own.zonepos - 1, 0)]; // 获取敌方场上最后一个召唤的随从
                }

                if (tinyfin != null && target != null)
                {
                    // 复制水宝宝鱼人的属性
                    tinyfin.Angr = target.Angr;
                    tinyfin.Hp = target.Hp;
                    tinyfin.maxHp = target.maxHp;

                    // 赋予鱼人宝宝突袭
                    // tinyfin.rush = 1; // 突袭的实现通常通过设置charge属性
                    // tinyfin.Ready = true;  // 让突袭随从可以立即攻击
                }
            }
        }
    }
}
