using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPPI_game
{
    /// <summary>
    /// Класс абстрактной сущности "персонаж"
    /// </summary>
    public abstract class Character
    {
        /// <summary>
        /// Очки здоровья персонажа
        /// </summary>
        private int _HP;

        /// <summary>
        /// Очки действий персонажа
        /// </summary>
        private int _STP;

        /// <summary>
        /// Скорость передвижения персонажа
        /// </summary>
        private int _movementSpeed;


        /// <summary>
        /// Бег персонажа.
        /// </summary>
        public void Run()
        {

        }

        /// <summary>
        /// Ускоренный бег.
        /// </summary>
        public void Accelerate()
        {

        }

        /// <summary>
        /// Приседание.
        /// </summary>
        public void Squat()
        {

        }
    }
}
