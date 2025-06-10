using System;
using System.Collections.Generic;
using System.Text;
using Triton.Game.Mapping;
using Triton.Game;

namespace HREngine.Bots
{
	//随从 猎人 费用：6 攻击力：3 生命值：7
	//Aggramar, the Avenger
	//复仇者阿格拉玛
	//<b>Titan</b><b>Battlecry:</b> Equip a3/3 Taeshalach.
	//<b>泰坦</b><b>战吼：</b>装备一把3/3的泰沙拉克。
	class Sim_TTN_092 : SimTemplate
	{
        CardDB.Card weapon = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.TTN_092t);
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            p.equipWeapon(weapon, own.own);
        }

        public override void useTitanAbility(Playfield p, Minion triggerMinion, int titanAbilityNO, Minion target)
        {
            Entity entity = GameState.Get().GetFriendlySidePlayer().GetHero();
            var creator = entity.GetTag(GAME_TAG.CREATOR);
            var cpyDeath = entity.GetTag(GAME_TAG.COPY_DEATHRATTLE);
            var ctrlId = entity.GetTag(GAME_TAG.CONTROLLER);
            switch (titanAbilityNO)
            {
                case 1: // 守护秩序
                    if (p.ownWeapon.Durability > 0)
                    {
                        p.ownWeapon.enchants.Add(new miniEnch(CardDB.cardIDEnum.TTN_092t1, creator, ctrlId, cpyDeath, entity));
                    }
                    break;

                case 2: // 统帅风范
                    if (p.ownWeapon.Durability > 0)
                    {
                        p.ownWeapon.enchants.Add(new miniEnch(CardDB.cardIDEnum.TTN_092t2, creator, ctrlId, cpyDeath, entity));
                    }
                    break;

                case 3: // 迅疾挥剑
                    if (p.ownWeapon.Durability > 0)
                    {
                        p.ownWeapon.Angr += 2;
                        p.ownWeapon.enchants.Add(new miniEnch(CardDB.cardIDEnum.TTN_092t3, creator, ctrlId, cpyDeath, entity));
                    }
                    break;
            }
        }
    }
}
