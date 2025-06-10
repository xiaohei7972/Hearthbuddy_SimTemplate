using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 巫妖王 费用：3 攻击力：4 生命值：2
	//Rambunctious Stuffy
	//毛绒暴暴狗
	//<b>Rush</b>After you cast a Frost spell, gain <b>Reborn</b>.
	//<b>突袭</b>在你施放一个冰霜法术后，获得<b>复生</b>。
	class Sim_TOY_821 : SimTemplate
	{

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.callKid(CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.TOY_821), p.ownMinions.Count, ownplay);
        }

        public override void onCardIsGoingToBePlayed(Playfield p, Handmanager.Handcard hc, bool ownplay, Minion triggerEffectMinion)
        {
            // 检查是否为冰霜法术
            if (ownplay == triggerEffectMinion.own && hc.card.SpellSchool == CardDB.SpellSchool.FROST)
            {
                // 给予触发效果的随从复生属性
                triggerEffectMinion.reborn = true;
            }
        }

    }
}
