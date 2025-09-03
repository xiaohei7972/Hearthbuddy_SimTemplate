using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 德鲁伊 费用：9 攻击力：9 生命值：9
	//Seismopod
	//震地雷龙
	//<b>Taunt</b>, <b>Elusive</b><b>Deathrattle:</b> Give all minions in your handand deck +3/+3.
	//<b>嘲讽</b>。<b>扰魔</b><b>亡语：</b>使你的手牌和牌库里的所有随从牌获得+3/+3。
	class Sim_DINO_421 : SimTemplate
	{
        public override void onDeathrattle(Playfield p, Minion m)
        {
            // 增强手牌中的所有随从
                foreach (Handmanager.Handcard hc in p.owncards)
                {
                    if (hc.card.type == CardDB.cardtype.MOB) // 检查是否为随从卡牌
                    {
                        hc.addattack += 3;
                        hc.addHp += 3;
                        p.anzOwnExtraAngrHp += 6;
                    }
                }

                // 增强牌库中的所有随从
                foreach (CardDB.Card card in p.ownDeck)
                {
                    if (card.type == CardDB.cardtype.MOB) // 检查是否为随从卡牌
                    {
                        card.Attack += 3; // 增加攻击力
                        card.Health += 3; // 增加生命值
                    }
                }
        }
		
	}
}
