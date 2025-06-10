using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 德鲁伊 费用：5 攻击力：3 生命值：5
	//Dozing Dragon
	//嗜睡巨龙
	//[x]<b>Dormant</b> for 2 turns.While <b>Dormant</b>, summona 3/5 Dragon with <b>Taunt</b>_at the end of your turn.
	//<b>休眠</b>2回合。<b>休眠</b>状态下，在你的回合结束时召唤一条3/5并具有<b>嘲讽</b>的龙。
	class Sim_VAC_511 : SimTemplate
	{

        CardDB.Card tauntDragon = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.VAC_511t); // 假设3/5嘲讽龙的卡牌ID是 VAC_511t

        public override void onTurnEndsTrigger(Playfield p, Minion triggerEffectMinion, bool turnEndOfOwner)
        {
            if (turnEndOfOwner == triggerEffectMinion.own && triggerEffectMinion.dormant <= 0)
            {
                int pos = triggerEffectMinion.zonepos;
                p.callKid(tauntDragon, pos, triggerEffectMinion.own); // 召唤3/5嘲讽龙
            }
        }
    }
}
