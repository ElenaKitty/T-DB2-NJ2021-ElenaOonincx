using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiggyBankAssignment
{
    /// <summary>
    /// Represents a piggy bank.
    /// </summary>
    public class PiggyBank
    {
        /// <summary>
        /// Gets the saved amount of money
        /// </summary>
        public int Savings { get; private set; }

        /// <summary>
        /// Initializes a new instance of the PiggyBank class with zero savings.
        /// </summary>
        public PiggyBank()
            : this(0)
        {
        }

        /// <summary>
        /// Initializes a new instance of the PiggyBank class using the 
        /// specified savings.
        /// </summary>
        /// <param name="savings">The value used to initialize the savings.
        ///                       Must be zero or positive. 
        ///                       If not zero or positive, then the savings
        ///                       will be initialized to zero. </param>
        public PiggyBank(int savings)
        {
            Savings = savings;
        }

        /// <summary>
        /// Saves the given amount to the piggy bank.
        /// </summary>
        /// <param name="amount">The amount to save. 
        ///                      Must be a positive value. 
        ///                      If not positive, then no changes will
        ///                      be made to the savings of the the Piggy Bank. 
        ///                      </param>
        public void Save(int amount)
        {
            Savings += amount;
        }

        /// <summary>
        /// Removes the given amount from the savings of the piggy bank.
        /// </summary>
        /// <param name="amount">The amount to remove from the savings.
        ///                      Must be a positive value. 
        ///                      If not positive, then no changes will
        ///                      be made to the savings.
        ///                      If the amount to remove is greater than the
        ///                      savings, then all of the savings are 
        ///                      removed (and no more). </param>
        /// <returns>The amount that was removed from the piggy bank</returns>
        public int Remove(int amount)
        {
            Savings -= amount;
            return amount;
        }
    }
}
