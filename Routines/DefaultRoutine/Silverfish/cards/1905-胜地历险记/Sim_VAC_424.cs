using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 法师 费用：4 攻击力：2 生命值：5
	//Raylla, Sand Sculptor
	//沙滩塑形师蕾拉
	//[x]<b>Paladin Tourist</b>After you cast a spell, summona random 2-Cost minion andgive it <b>Divine Shield</b>.
	//<b>圣骑士游客</b>在你施放一个法术后，随机召唤一个法力值消耗为（2）的随从并使其获得<b>圣盾</b>。
	class Sim_VAC_424 : SimTemplate
	{
        public override void onCardIsGoingToBePlayed(Playfield p, Handmanager.Handcard hc, bool wasOwnCard, Minion triggerEffectMinion)
        {
            // 确保是玩家自己施放的法术
            if (wasOwnCard && hc.card.type == CardDB.cardtype.SPELL && triggerEffectMinion.own)
            {
                // 使用 getRandomCardForManaMinion 方法获取一个随机的2费随从
                CardDB.Card randomMinion = p.getRandomCardForManaMinion(2);

                // 使用 callKid 方法召唤该随从
                p.callKid(randomMinion, triggerEffectMinion.zonepos, triggerEffectMinion.own);

                // 获取最后召唤的随从
                Minion summonedMinion = p.ownMinions[p.ownMinions.Count - 1];

                // 赋予圣盾效果
                summonedMinion.divineshild = true;
            }
        }
    }
}
