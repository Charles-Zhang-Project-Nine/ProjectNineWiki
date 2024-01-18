# TODO

<!-- Should we use projects? Projects is reserved for published Project Nine tasks to the public, which we shall not use now. 
Should we use Issues for todo? Issues should really be used for technical issues - some of the "todos" might be issues.
Should we use Discussion for ideas, advice, feature requests, and issues? Maybe. Again, that's for public use, for internal and collaborator use, we just use this TODO.
-->

*This TODO document is for internal use.*

Looks like we are going all text-based, which is good; And external media will be hosted seperately on image and digital asset hosts (at the moment we use Uploadcare and Cloudinary) - with some other cloud based services, we can make the wiki experience richer.

License:

- [ ] Replace license to Project Nine specific license

Basic Template (based on git-wiki):

- [x] (20240115) Mermaid rendering
    * Per https://github.com/TotalImagine-com/TotalImagine.com/commit/035a2731e5d3c12e21c03e8beb0bbde0391d9715#diff-907a69846a1f6b238f1c43199984197d12c7eab26f3c3adcd45d628b26644950
    * https://www.drassil.org/git-wiki/customize
    * Most likely we just need to use one of the hooks to inject the script reference we need
    * Done. See minimal configuration demo here: https://github.com/Charles-Zhang-Fork/git-wiki-skeleton/tree/Test-Mermaid-Manual
    * See https://github.com/Charles-Zhang-Project-Nine/ProjectNineWiki/pull/3
- [x] (20240115) LaTex rendering
    * Per https://github.com/TotalImagine-com/TotalImagine.com/commit/17acd5403cadf70737d7e14b49d7e85261e77748
    * See https://github.com/Charles-Zhang-Project-Nine/ProjectNineWiki/pull/3
- [ ] (#Tentative, Proposal, #20240118) Create dedicated top-level navigation for Medalian languages
    * The intention is to provide information on language proper, not a typical wiki entry for language - which we already have a folder for it.
    * We need to think about how to structure this (should we also put one for Tellurian languages? What about Fepulans, Krukian and other alien languages?) Actually for Tellurian languages we should just mention in the main wiki and for special usages we can either create entry in main wiki or from sidebar level. For alien languages, we will worry about them when we have them.
    * What are the implications between en/Chinese/Japanese version of the wiki?
    - [ ] We will worry about this when Medalian languages are more developed.

Basic Layout:

- [ ] Add Spoiler Alert (with custom CSS) on front page.

Features:

- [ ] Add celestia map on front page as welcome
- [ ] Add babylon/playcanvas visualization for objects
- [ ] Add navigation map visualization for city locations

Issues:

- [x] (20240115) Missing "Contents"/navigation sidebar - not rendering since https://github.com/Charles-Zhang-Project-Nine/ProjectNineWiki/pull/2
    * It's because the template requires show pages (which include "recent" pages) in order to show additional sidebar items
    * See: https://github.com/Charles-Zhang-Fork/git-wiki-skeleton/tree/Test-ModifySidebar
    * See: https://github.com/Charles-Zhang-Project-Nine/ProjectNineWiki/pull/3/commits/161a70e8103410a99ab598157a3d3a3b078ce590