using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HREngine.Bots
{
	//随从 恶魔猎手 费用：7 攻击力：5 生命值：9
	//Argus, the Emerald Star
	//翠绿之星阿古斯
	//[x]<b>Titan</b>Minions to the left of thishave <b>Rush</b>, and ones to theright have <b>Lifesteal</b>.
	//<b>泰坦</b>本随从左边的随从均拥有<b>突袭</b>，本随从右边的随从均拥有<b>吸血</b>。
	class Sim_TTN_862 : SimTemplate
	{
        public override void useTitanAbility(Playfield p, Minion triggerMinion, int titanAbilityNO, Minion target)
        {
            switch (titanAbilityNO)
            {
                case 1: // 雕琢晶石
                    p.drawACard(CardDB.cardIDEnum.None, true); // 发现一张亡语随从牌
                    p.owncards.Skip(Math.Max(0, p.owncards.Count - 1)).ToList().ForEach(handCard =>
                    {
                        handCard.manacost -= 3;
                    });
                    break;

                case 2: // 力量展现
                    p.owncards.ForEach(card =>
                    {
                        if (card.card.type == CardDB.cardtype.MOB)
                        {
                            card.manacost -= 2;
                        }
                    });
                    break;

                case 3: // 阿古尼特大军
                    for (int i = 0; i < 4; i++)
                    {
                        p.callKid(CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.TTN_862t4), p.ownMinions.Count, true, false); // 召唤4个2/2并具有嘲讽的元素
                    }
                    break;
            }
        }
    }
}
