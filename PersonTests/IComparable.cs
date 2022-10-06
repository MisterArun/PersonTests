namespace PersonTests
{
    /// <summary>
    /// Compares two Persons.
    /// </summary>
    internal interface IComparable<Person>
    {
        /// <summary>
        /// Compares two Persons.
        /// </summary>
        /// <param name="person">A second person that is compared.</param>
        /// <returns>whether the Persons match or not.</returns>
        public int CompareTo(Person person);
    }
}
