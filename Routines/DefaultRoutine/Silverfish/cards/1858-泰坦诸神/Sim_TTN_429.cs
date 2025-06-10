using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HREngine.Bots
{
	//随从 潜行者 费用：7 攻击力：3 生命值：10
	//Aman'Thul
	//阿曼苏尔
	//<b>Titan</b>After this uses anability, <b>Discover</b> any <b>Legendary</b> minion.
	//<b>泰坦</b>在本随从使用一个技能后，<b>发现</b>任意<b>传说</b>随从牌。
	class Sim_TTN_429 : SimTemplate
	{
        public override void useTitanAbility(Playfield p, Minion triggerMinion, int titanAbilityNO, Minion target)
        {
            switch (titanAbilityNO)
            {
                case 1: // 塑造星辰
                    if (target != null)
                    {
                        target.Angr += 2;
                        target.Hp += 2;
                        p.callKid(target.handcard.card, p.ownMinions.Count, true, false); // 召唤一个具有+2/+2的复制
                    }
                    p.drawACard(CardDB.cardIDEnum.None, true);
                    break;

                case 2: // 扫出历史
                    p.RemoveMinionWithoutDeathrattle(target); // 移出战场 待完善
                    p.drawACard(CardDB.cardIDEnum.None, true);
                    break;

                case 3: // 英雄视界
                    CardDB.Card kidCard = p.getRandomCardForManaMinion(4);
                    p.callKid(kidCard, p.ownMinions.Count, true, false); // 召唤一个6费的随从并赋予嘲讽和吸血
                    p.drawACard(CardDB.cardIDEnum.None, true);
                    break;

            }
        }
    }
}
