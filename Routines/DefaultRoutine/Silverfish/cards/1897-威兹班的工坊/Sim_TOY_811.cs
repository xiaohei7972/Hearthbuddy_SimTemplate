using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 圣骑士 费用：4 攻击力：3 生命值：2
	//Tigress Plushy
	//绒绒虎
	//<b>Miniaturize</b><b>Rush</b>, <b>Lifesteal</b>,<b>Divine Shield</b>
	//<b>微缩</b><b>突袭</b>，<b>吸血</b>，<b>圣盾</b>
	class Sim_TOY_811 : SimTemplate
	{

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            // 处理微缩效果，假设微缩效果是抽一张衍生物卡牌
            p.drawACard(CardDB.cardIDEnum.TOY_811t, ownplay, true); // 替换为实际的衍生物卡牌 ID
        }

    }
}
