using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    // 随从 中立 费用：3 攻击力：2 生命值：4
    // Hozen Roughhouser
    // 粗暴的猢狲
    // Whenever another friendly Pirate attacks, give it +1/+1.
    // 每当其他友方海盗攻击时，使其获得+1/+1。
    class Sim_VAC_938 : SimTemplate
    {
        // 当随从攻击时触发此方法
        public override void onMinionAttack(Playfield p, Minion attacker, Minion target)
        {
            // 检查攻击者是否为友方海盗
            if (attacker.own && RaceUtils.IsRaceOrAll(attacker.handcard.card.race, CardDB.Race.PIRATE))
            {
                // 获取“粗暴的猢狲”的卡牌数据
                CardDB.Card roughhouserCard = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.VAC_938);

                // 遍历场上的所有随从，寻找所有“粗暴的猢狲”
                foreach (Minion m in p.ownMinions)
                {
                    // 如果找到“粗暴的猢狲”并且该随从未被沉默
                    if (m.handcard.card.cardIDenum == roughhouserCard.cardIDenum && !m.silenced)
                    {
                        // 使攻击的海盗获得+1/+1
                        attacker.Angr += 1;
                        attacker.Hp += 1;
                    }
                }
            }
        }
    }
}
